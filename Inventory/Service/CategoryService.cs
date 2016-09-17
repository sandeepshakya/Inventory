using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model.Models;
using Vm = Service.ViewModel;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
namespace Service
{
    public class CategoryService : ICategoryService
    {
        public long UpdateSave(ProductCategory model, long id)
        {
            using (var dbContxt = new InventoryContext())
            {
                var dbModel = id > 0 ? dbContxt.ProductCategories.FirstOrDefault(cat => cat.Id == id && cat.CompanyId == model.CompanyId)
                    : dbContxt.ProductCategories.Add(model);

                if (id > 0)
                {
                    dbModel.Name = model.Name;
                    dbModel.UserName = model.UserName;
                    dbContxt.Entry(dbModel).State = EntityState.Modified;
                }

                if (dbContxt.SaveChanges() > 0)
                    return dbModel.Id;

                return dbModel.Id;
            }
        }

        public IReadOnlyDictionary<long, string> GetCategoryListForDropdown(long companyId)
        {
            using (var dbCntxt = new InventoryContext())
            {
                return dbCntxt.ProductCategories.Where(cm => cm.CompanyId == companyId)
                    .OrderByDescending(cat => cat.Id)
                    .ToDictionary(t => t.Id, t => t.Name);
            }
        }

        public IReadOnlyList<ProductCategory> GetCategoryList(long companyId)
        {
            using (var dbCntxt = new InventoryContext())
            {
                return dbCntxt.ProductCategories.Where(cm => cm.CompanyId == companyId)
                    .OrderByDescending(prd => prd.Id)
                    .ToList();
            }
        }

        public bool CheckDuplicate(long companyId, string name, long id)
        {
            using (var dbCntxt = new InventoryContext())
            {
                return dbCntxt.ProductCategories
                    .Any(cm => cm.CompanyId == companyId
                        && cm.Name.ToLower() == name.ToLower()
                        && cm.Id != id);
            }
        }

        public ProductCategory GetCategoryById(long id)
        {
            using (var dbCntxt = new InventoryContext())
            {
                return dbCntxt.ProductCategories.FirstOrDefault(cm => cm.Id == id);
            }
        }

        public int Delete(long id)
        {
            try
            {
                if (id != 0)
                {
                    ProductCategory categoryToDelete;
                    //1. Get student from DB
                    using (var ctx = new InventoryContext())
                    {
                        categoryToDelete = ctx.ProductCategories.Where(s => s.Id == id).FirstOrDefault<ProductCategory>();
                    }

                    //Create new context for disconnected scenario
                    using (var newContext = new InventoryContext())
                    {
                        newContext.Entry(categoryToDelete).State = System.Data.Entity.EntityState.Deleted;

                        newContext.SaveChanges();
                    }  
                }

            }
            catch (Exception ex)
            {
                return 0;
                throw new ArgumentNullException("Error occurred while deleteing category Record");
            }

            return 1;
        }

    }
}
