using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Model.Models;

using Service.Enums;
using Service.ViewModel;
using Vm = Service.ViewModel;
using SalesOrder = Model.Models.SalesOrder;

namespace Service
{
    public class SalesOrderService : ISalesOrderService
    {
        /// <summary>
        // This is special method which is used for Transaction.
        // See PurchaseOrderService.cs UpdateSave(List<PurchaseOrder> model) for Transaction
        /// </summary>
        /// <param name="model"></param>
        /// <param name="dbCntxt"></param>
        public void UpdateSave(SalesOrder model, InventoryContext dbCntxt)
        {
            dbCntxt.SalesOrders.Add(model);
        }

        public string IssueOrder(SalesOrder model, List<SalesOrderProducts> salesProducts)
        {
            var productService = new ProductService();
            var poService = new PurchaseOrderService();
            var poModel = poService.PurchaseOrderSearchResult(model.CompanyId.Value, model.PONumber);
            
            model.Status = SalesOrderStatus.Issued.ToString();

            using (var dbContxt = new InventoryContext())
            {
                //var productByPoNumber = dbContxt.PurchaseOrders.Where(po => po.Number == model.PONumber);
                var dbModel = dbContxt.SalesOrders.FirstOrDefault(so => so.Number == model.Number);

                dbModel.Comments = model.Comments;
                dbModel.ApprovedQnty = model.ApprovedQnty;
                dbModel.PaymentMode = model.PaymentMode;
                dbModel.Status = model.Status;
                dbModel.TotalPrice = model.TotalPrice;
                
                // If SO is created then we need to update ACTUAL Product Quantities , to reflect latest Stock
                int updateStock = productService.UpdateStock(
                    salesProducts.Select(po => new Vm.Product
                    {
                        Id = po.ProductId,
                        Quantity = po.Quantity
                    }).ToList()
                    , dbContxt);

                dbContxt.Entry(dbModel).State = EntityState.Modified;
               int result = dbContxt.SaveChanges();
               
               if (result > 0)
                   return model.Number;

               return string.Empty;
            }
        }

        public IReadOnlyCollection<ViewModel.SalesOrderProducts> SearchResult(string poNumber)
        {
            using (var dbCntxt = new InventoryContext())
            {
                return dbCntxt.PurchaseOrders
                    .Include("Product")
                    .Include("Company")
                    .Where(po => po.Number == poNumber)
                    .AsNoTracking()
                      .Select(po => new ViewModel.SalesOrderProducts
                      {
                          Id = po.Id,
                          ProductId = po.ProductId,
                          ProductName = po.Product.ProductName,
                          UnitPrice = po.UnitPrice,
                          Quantity = po.OrderedQty,
                          Total = po.TotalAmount,
                          Buyer = po.Company.Name,
                          OrderDate = po.OrderDate,
                          ProductCode = po.Product.Number,
                          PONumber = po.Number,
                          ShippingAddress = po.Company.Address,
                          BuyerPhone = po.Company.ContactNo,
                          BuyerEmail  = po.Company.Email
                      }).ToList();
            }
        }

        public IReadOnlyCollection<SalesOrder> GetByNumber(string soNumber)
        {
            using (var dbCntxt = new InventoryContext())
            {
                return dbCntxt.SalesOrders.Where(so => so.Number == soNumber).ToList();
            }
        }

        public IReadOnlyCollection<SoInvoice> Invoice(string soNumber, string poNumber)
        {
            var getPo = SearchResult(poNumber);
            var getSo = GetByNumber(soNumber);

            if (getPo.Count == 0 && getSo.Count == 0)
                return new List<SoInvoice>();

            decimal grandTotal = getSo.Select(so => so.TotalPrice.HasValue ? so.TotalPrice.Value : 0).Sum();

            var getInvoiceDetails = (from so in getSo
                                     join po in getPo on so.PONumber equals po.PONumber
                                     select new SoInvoice
                                     {
                                         ApprovedQty = so.ApprovedQnty,
                                         InvDate = so.OrderDate.Value,
                                         Name = po.ProductCode,
                                         PurchasedBy = po.Buyer,
                                         PoNumber = po.PONumber,
                                         OrderedQty = po.Quantity.ToString(),                                         
                                         ShippingAddress = po.ShippingAddress,
                                         UnitPrice = po.UnitPrice,
                                         GrandTotal = grandTotal,
                                         TotalPrice = so.TotalPrice.Value,
                                         SoNumber = so.Number,
                                         Status = so.Status,
                                         PaymentMode = so.PaymentMode,
                                         SupplierPhone = po.BuyerPhone,
                                         SupplierEmail = po.BuyerEmail
                                     }).ToList();

            return getInvoiceDetails;

        }

        public IReadOnlyCollection<SalesOrderProducts> SearchResult(long companyId)
        {
            using (var dbCntxt = new InventoryContext())
            {
                var companyName = dbCntxt.Companies.Find(companyId).Name;

                return dbCntxt.SalesOrders
                    .Include("Product")
                    .Include("Company")
                     .Where(so => so.CompanyId == companyId)
                      .AsNoTracking()
                      .Select(so => new ViewModel.SalesOrderProducts
                      {
                          Id = so.Id,
                          SONumber = so.Number,
                          Buyer = companyName,
                          OrderDate = so.OrderDate.Value,
                          Total = so.TotalPrice.HasValue ? so.TotalPrice.Value : 0,
                          Status = so.Status,
                          Quantity = so.ApprovedQnty.HasValue ? so.ApprovedQnty.Value : 0,
                          PaymentMode = so.PaymentMode,
                          PONumber = so.PONumber
                      }).ToList();
            }
        }

        public IReadOnlyList<SalesOrderList> GetSalesOrderForDropDownList()
        {
            using (var dbCntxt = new InventoryContext())
            {
                return dbCntxt.SalesOrders.AsNoTracking()
                    .Where(so => so.Status == SalesOrderStatus.Pending.ToString())
                    .Select(so => new SalesOrderList
                    {
                        PoNumber = so.PONumber,
                        SoNumber = so.Number
                    })
                    .ToList();
            }
        }
    }
}
