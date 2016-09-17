using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Vm = Service.ViewModel;
namespace Service
{
    public class ProductService : IProductService
    {
        public IReadOnlyDictionary<long, string> ProductListForDropDown(long companyId)
        {
            using (var dbCntxt = new InventoryContext())
            {
                return dbCntxt.Products.Where(prd => prd.CompanyId == companyId)
                    .OrderByDescending(prd => prd.Id)
                    .ToDictionary(t => t.Id, t => t.ProductName);
            }
        }

        public long UpdateSave(Product model, long id)
        {
            var numberRangeService = new NumberRangeService();

            using (var dbContxt = new InventoryContext())
            {
                var dbModel = id > 0 ? dbContxt.Products.Find(id) : dbContxt.Products.Add(model);

                if (id > 0)
                {
                    dbModel.ProductName = model.ProductName;
                    dbModel.CategoryId = model.CategoryId;
                    dbModel.IsImageExist = model.IsImageExist;
                    dbModel.LocationId = model.LocationId;
                    dbModel.UserName = model.UserName;
                    dbModel.ObjName = model.ObjName;
                    dbModel.ProductCost = model.ProductCost;
                    dbModel.Quantity = model.Quantity;
                    dbModel.NotifyLowQuantity = model.NotifyLowQuantity;
                    dbModel.ImageUrl = model.ImageUrl;
                    dbContxt.Entry(dbModel).State = EntityState.Modified;
                }
                else // Product Number is geneated once. Should not be updated.
                {
                    dbModel.Number = numberRangeService.GenerateRandomNumber("Product");
                }

                if (dbContxt.SaveChanges() > 0)
                    return dbModel.Id;

                return dbModel.Id;
            }
        }

        public int UpdateStock(List<Vm.Product> poViewModel, InventoryContext dbContxt)
        {
            try
            {
                var getListId = poViewModel.Select(vm => vm.Id).ToList();
                var dbModel = dbContxt.Products.Where(prd => getListId.Contains(prd.Id)
                    ).ToList();

                // Updating Actual Quantities - Entered in Purchase Orders.
                // Substract Total Quantity - Entered in Purchase Orders
                dbModel
                    .ForEach(x => x.Quantity = x.Quantity - (poViewModel.Where(vm => vm.Id == x.Id).Select(vm => vm.Quantity).FirstOrDefault()
                ));

                // Notify Context that Whole collection is updated.
                dbContxt.Products.ForEachAsync(p => dbContxt.Entry(p).State = EntityState.Modified);
                return 1;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Transaction is rolled back.Please see inner exception: " + ex.InnerException.ToString());
            }
        }

        public bool CheckDuplicate(long categoryId, long companyId, string name, long id)
        {
            using (var dbCntxt = new InventoryContext())
            {
                return dbCntxt.Products.Any(prd => prd.CompanyId == companyId
                    && prd.CategoryId == categoryId
                    && prd.ProductName.ToLower() == name.ToLower() && prd.Id != id);
            }
        }

        public IReadOnlyList<Vm.Product> GetProductList(long companyId)
        {
            var list = new List<Vm.Product>();

            using (var dbCntxt = new InventoryContext())
            {
                try
                {
                    list = dbCntxt.Products
                       .Where(prd => prd.CompanyId == companyId && prd.Quantity > 0)
                       .Select(prd => new Vm.Product
                       {
                           Id = prd.Id,
                           Number = prd.Number,
                           ProductName = prd.ProductName,
                           Location = prd.ProductLocation.Locaton,
                           Quantity = prd.Quantity.Value,
                           ProductCost = prd.ProductCost,
                           Category = prd.ProductCategory.Name,
                           SubCategory = prd.SubCategory.Name,
                           NotifyLowQuantity = prd.NotifyLowQuantity.Value,
                           ImageUrl = prd.ImageUrl
                       }).OrderByDescending(prd => prd.Id)
                       .ToList();
                }
                catch (Exception ex)
                {
                    string exMsg = ex.ToString();
                    return null;
                }

                return list;
                    
            }
        }

        public Product GetProductById(long id, long companyId)
        {
            using (var dbCntxt = new InventoryContext())
            {
                return dbCntxt.Products.FirstOrDefault(prd => prd.CompanyId == companyId && prd.Id == id);
            }
        }

        public int Delete(long id)
        {
            try
            {
                if (id != 0)
                {
                    Product productToDelete;
                    //1. Get student from DB
                    using (var ctx = new InventoryContext())
                    {
                        productToDelete = ctx.Products.Where(s => s.Id == id).FirstOrDefault<Product>();
                    }

                    //Create new context for disconnected scenario
                    using (var newContext = new InventoryContext())
                    {
                        newContext.Entry(productToDelete).State = System.Data.Entity.EntityState.Deleted;

                        newContext.SaveChanges();
                    }
                }

            }
            catch (Exception ex)
            {
                return 0;
                throw new ArgumentNullException("Error occurred while deleteing product Record");
            }

            return 1;
        }

    }
}
