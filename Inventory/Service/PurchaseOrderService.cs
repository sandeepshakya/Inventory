using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Service.Enums;
using Vm = Service.ViewModel;
namespace Service
{
   public class PurchaseOrderService : IPurchaseOrderService
    {
       /// <summary>
       /// NOTE : DON'T COPY THIS METHOD SINCE IT CONTAINS TRANSACTION
       /// COPY IT IF YOU ARE USING TRANSACTION ESPECIALLY FOR INVOICE / PURCHASE ORDER / AMOUNT RELATED OPERATIONS.
       /// In a single commit we need to save data into SalesOrder, PurchaseOrder and Update Stock in Product table.
       /// </summary>
       /// <param name="model"></param>
       /// <returns></returns>
       public string UpdateSave(List<PurchaseOrder> model)
       {
           var productService = new ProductService();
           using (var dbCntxt = new InventoryContext())
           {
               using (DbContextTransaction dbTran = dbCntxt.Database.BeginTransaction())
               {
                   try
                   {
                       dbCntxt.PurchaseOrders.AddRange(model);

                       /// When a PO is created, SO is also created to notify Vendors
                       /// that one PO Order is arrived, create salesorder now and issue to customer.
                       /// 
                       CreateSalesOrder(model, dbCntxt);

                       int result = dbCntxt.SaveChanges();

                       if (result > 0)
                       {
                           dbTran.Commit();
                           return model.FirstOrDefault().Number;
                       }

                       throw new ArgumentException("Purchase order is not created.Contact System Admin");
                   }
                   catch (Exception ex)
                   {
                       //Rollback transaction if exception occurs
                       dbTran.Rollback();
                       throw new ArgumentException("Transaction is rolled back.Please see inner exception: " + ex.ToString());
                   }
               }
           }
       }

       private void CreateSalesOrder(List<PurchaseOrder> model, InventoryContext dbCntxt)
       {
           var salesOrderModel = new SalesOrder();
           var numberRangeService = new NumberRangeService();

           salesOrderModel.VendorId = model.FirstOrDefault().VendorId;
           salesOrderModel.PONumber = model.FirstOrDefault().Number;
           salesOrderModel.OrderDate = model.FirstOrDefault().OrderDate;
           salesOrderModel.CompanyId = model.FirstOrDefault().CompanyId;
           salesOrderModel.Status = SalesOrderStatus.Pending.ToString();
           salesOrderModel.Number = numberRangeService.GenerateRandomNumber("SalesOrder");
           var salesOrderService = new SalesOrderService();

           salesOrderService.UpdateSave(salesOrderModel, dbCntxt);
       }

       public IReadOnlyList<Vm.PurchaseOrderProducts> GetProductByIdForPurchaseOrder(long companyId, long id)
       {
           var listPoProduct = new List<Vm.PurchaseOrderProducts>();
           using (var dbCntxt = new InventoryContext())
           {
               var result = dbCntxt.Products.Where(prd => prd.Id == id && prd.CompanyId == companyId)
                   .Select(prd => new
                   {
                       Id = prd.Id,
                       UnitPrice = prd.ProductCost,
                       Qntity = prd.Quantity,
                       Name = prd.ProductName
                   });

               var total = result.Select(tr => tr.UnitPrice * tr.Qntity).Sum();

               listPoProduct = result.Select(rs => new Vm.PurchaseOrderProducts
               {
                   Id = rs.Id,
                   Name = rs.Name,
                   GrandTotal = 0,
                   Total = total.Value,
                   Quantity = rs.Qntity.Value,
                   UnitPrice = rs.UnitPrice
               }).ToList();

               return listPoProduct;
           }
       }

       public IReadOnlyList<Vm.PurchaseOrderSearchResult> PurchaseOrderSearchResult(long companyId)
       {
           using (var dbCntxt = new InventoryContext())
           {
               var result = dbCntxt.PurchaseOrders
                    .Where(po => po.CompanyId == companyId)
                    .Include("Vendors") // Eager Loading
                    .GroupBy(po => po.Number)
                    .Select(po => new Vm.PurchaseOrderSearchResult
                    {
                        Id = po.FirstOrDefault().Id,
                        OrderDate = po.FirstOrDefault().OrderDate,
                        OrderQty = po.FirstOrDefault().OrderedQty,
                        PoNumber = po.FirstOrDefault().Number,
                        GrandTotal = po.Sum(w => w.TotalAmount),
                        Vendor = po.FirstOrDefault().Vendor.Name,
                        PurchasedBy = "System User"
                    }).OrderByDescending(po => po.OrderDate);
             
               return result.ToList();
           }
       }

       public IReadOnlyList<Vm.PoInvoice> PurchaseOrderSearchResult(long companyId, string poNumber)
       {
           using (var dbCntxt = new InventoryContext())
           {
               var getDetails = dbCntxt.PurchaseOrders
                    .Where(po => po.CompanyId == companyId)
                    .Where(po => po.Number == poNumber)
                    .Include("Vendor") // Eager Loading
                    .Include("Product")
                    .ToList();

               var result = getDetails
                   .GroupBy(x =>
                       new
                       {
                           x.Number,
                           x.ProductId
                       })
                   .Select((po, iterator) => new Vm.PoInvoice
                    {
                        SlNumber = +iterator + 1,
                        PoNumber = po.FirstOrDefault().Number,
                        PurchasedBy = "System User",
                        Quantity = po.FirstOrDefault().OrderedQty,
                        UnitPrice = po.FirstOrDefault().UnitPrice,
                        GrandTotal = po.Sum(ps => ps.TotalAmount),
                        Name = po.FirstOrDefault().Product.ProductName,
                        SupplierAddress = po.FirstOrDefault().Vendor.Address1,
                        SupplierEmail = po.FirstOrDefault().Vendor.Email,
                        SupplierPhone = po.FirstOrDefault().Vendor.Mobile,
                        InvDate = po.FirstOrDefault().OrderDate,
                    });

               return result.ToList();
           }
       }
    }
}
