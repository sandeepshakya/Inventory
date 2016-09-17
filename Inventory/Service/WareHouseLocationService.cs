using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Service
{
    public class WareHouseLocationService : IWareHouseLocationService
    {
        public IReadOnlyDictionary<long, string> LocationListForDropDown()
        {
            using (var dbCntxt = new InventoryContext())
            {
                return dbCntxt.ProductLocations
                    .AsNoTracking() // ReadOnly Data.
                    .OrderByDescending(t => t.Id)
                    .ToDictionary(t => t.Id, t => t.Locaton);
            }
        }
        
        public IReadOnlyCollection<ProductLocation> SearchResult()
        {
            using (var dbCntxt = new InventoryContext())
            {
                return dbCntxt.ProductLocations.OrderByDescending(loc => loc.Id)
                    .AsNoTracking() // ReadOnly Data.
                    .ToList();
            }
        }

        public ProductLocation GetById(long id)
        {
            using (var dbCntxt = new InventoryContext())
            {
                return dbCntxt.ProductLocations.Find(id);                   
            }
        }

        public long UpdateSave(ProductLocation model, long id)
        {
            using (var dbContxt = new InventoryContext())
            {
                var dbModel = id > 0 ? dbContxt.ProductLocations.Find(id) : dbContxt.ProductLocations.Add(model);
                if (id > 0)
                {
                    dbModel.Locaton = model.Locaton;
                    dbModel.Address = model.Address;
                    dbContxt.Entry(dbModel).State = EntityState.Modified;

                }
                if (dbContxt.SaveChanges() > 0)
                    return dbModel.Id;

                return dbModel.Id;
            }
        }

        public bool CheckDuplicate(string name, long id)
        {
            using (var dbCntxt = new InventoryContext())
            {
                return dbCntxt.ProductLocations
                    .AsNoTracking() // ReadOnly Data.
                    .Any(att => att.Locaton.ToLower() == name.ToLower() 
                        && att.Id != id);
            }
        }

        public int Delete(long id)
        {
            try
            {
                if (id != 0)
                {
                    ProductLocation LocToDelete;
                    //1. Get student from DB
                    using (var ctx = new InventoryContext())
                    {
                        LocToDelete = ctx.ProductLocations.Where(s => s.Id == id).FirstOrDefault<ProductLocation>();
                    }

                    //Create new context for disconnected scenario
                    using (var newContext = new InventoryContext())
                    {
                        newContext.Entry(LocToDelete).State = System.Data.Entity.EntityState.Deleted;

                        newContext.SaveChanges();
                    }
                }

            }
            catch (Exception ex)
            {
                return 0;
                throw new ArgumentNullException("Error occurred while deleteing location Record");
            }

            return 1;
        }
    }
}
