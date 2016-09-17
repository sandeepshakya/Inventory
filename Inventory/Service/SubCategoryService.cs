using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Service
{
    public class SubCategoryService : ISubCategoryService
    {
        public long UpdateSave(SubCategory model, long id)
        {
            using (var dbContxt = new InventoryContext())
            {
                var dbModel = id > 0 ? dbContxt.SubCategories.Find(id) : dbContxt.SubCategories.Add(model);
                if (id > 0)
                {
                    dbModel.Name = model.Name;
                    dbModel.CategoryId = model.CategoryId;
                    dbContxt.Entry(dbModel).State = EntityState.Modified;

                }
                if (dbContxt.SaveChanges() > 0)
                    return dbModel.Id;

                return dbModel.Id;
            }
        }

        public IReadOnlyDictionary<long, string> GetSubCategoryListForDropdown(long categoryId)
        {
            using (var dbCntxt = new InventoryContext())
            {
                return dbCntxt.SubCategories.Where(cm => cm.CategoryId == categoryId)
                    .ToDictionary(t => t.Id, t => t.Name);
            }
        }

        public SubCategory GetSubCategoryById(long id)
        {
            using (var dbCntxt = new InventoryContext())
            {
                return dbCntxt.SubCategories.Find(id);
            }
        }

        public bool CheckDuplicate(string name, long categoryId, long id)
        {
            using (var dbCntxt = new InventoryContext())
            {
                return dbCntxt.SubCategories.Any(att => att.CategoryId == categoryId && att.Name.ToLower() == name.ToLower() && att.Id != id);
            }
        }

        public IReadOnlyList<ViewModel.SubCategory> SubCategorySearchResult()
        {
            using (var dbContxt = new InventoryContext())
            {
                return dbContxt.SubCategories.Include("ProductCategory")
                    .Select(sb => new ViewModel.SubCategory
                    {
                        Id = sb.Id,
                        CatName = sb.ProductCategory.Name,
                        Name = sb.Name
                    }).ToList();
            }
        }

        public int Delete(long id)
        {
            try
            {
                if (id != 0)
                {
                    SubCategory subcategoryToDelete;
                    //1. Get student from DB
                    using (var ctx = new InventoryContext())
                    {
                        subcategoryToDelete = ctx.SubCategories.Where(s => s.Id == id).FirstOrDefault<SubCategory>();
                    }

                    //Create new context for disconnected scenario
                    using (var newContext = new InventoryContext())
                    {
                        newContext.Entry(subcategoryToDelete).State = System.Data.Entity.EntityState.Deleted;

                        newContext.SaveChanges();
                    }
                }

            }
            catch (Exception ex)
            {
                return 0;
                throw new ArgumentNullException("Error occurred while deleteing subcategory Record");
            }

            return 1;
        }
    }
}
