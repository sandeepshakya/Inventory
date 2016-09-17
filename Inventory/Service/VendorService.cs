using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Service
{
    public class VendorService : IVendorService
    {
        public long UpdateSave(Vendor model, long id)
        {
            using (var dbCntxt = new InventoryContext())
            {
                var dbModel = id > 0 ? dbCntxt.Vendors.Find(id) : dbCntxt.Vendors.Add(model);

                if (id > 0)
                {
                    dbModel.Address1 = model.Address1;
                    dbModel.Address2 = model.Address2;
                    dbModel.Email = model.Email;
                    dbModel.IsApplicable = model.IsApplicable;
                    dbModel.Mobile = model.Mobile;
                    dbModel.Office = model.Office;
                    dbModel.Website = model.Website;
                    dbModel.UserName = model.UserName;
                    dbCntxt.Entry(dbModel).State = EntityState.Modified;
                }

                if (dbCntxt.SaveChanges() > 0)
                    return dbModel.Id;

                return dbModel.Id;
            }
        }

        public long Delete(long id)
        {
            using (var dbCntxt = new InventoryContext())
            {
                var dbModel = dbCntxt.Vendors.Find(id);
                dbCntxt.Entry(dbModel).State = System.Data.Entity.EntityState.Deleted;

                if (dbCntxt.SaveChanges() > 0)
                    return dbModel.Id;

                return dbModel.Id;
            }
        }

        public bool CheckDuplicate(string vendorName, long companyId, long id)
        {
            using (var dbCntxt = new InventoryContext())
            {
                return dbCntxt.Vendors.Any(cm => cm.Name.ToLower() == vendorName.ToLower() && cm.CompanyId == companyId && cm.Id != id);
            }
        }

        public IReadOnlyDictionary<long, string> GetVendorListForDropDown(long companyId)
        {
            using (var dbCntxt = new InventoryContext())
            {
                return dbCntxt.Vendors.Where(cm => cm.CompanyId == companyId)
                    .OrderByDescending(cm => cm.Id)
                    .ToDictionary(t => t.Id, t => t.Name);
            }
        }

        public IReadOnlyList<Vendor> GetVendorList(long companyId)
        {
            using (var dbCntxt = new InventoryContext())
            {
                return dbCntxt.Vendors.Where(cm => cm.CompanyId == companyId)
                    .OrderByDescending(cm => cm.Id)
                    .ToList();
            }
        }

        public Vendor GetVendorById(long id)
        {
            using (var dbCntxt = new InventoryContext())
            {
                return dbCntxt.Vendors.FirstOrDefault(cm => cm.Id == id);                 
            }
        }

        //public int Delete(long id)
        //{
        //    try
        //    {
        //        if (id != 0)
        //        {
        //            Vendor vendorToDelete;
        //            //1. Get student from DB
        //            using (var ctx = new InventoryContext())
        //            {
        //                vendorToDelete = ctx.Vendors.Where(s => s.Id == id).FirstOrDefault<Vendor>();
        //            }

        //            //Create new context for disconnected scenario
        //            using (var newContext = new InventoryContext())
        //            {
        //                newContext.Entry(vendorToDelete).State = System.Data.Entity.EntityState.Deleted;

        //                newContext.SaveChanges();
        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        return 0;
        //        throw new ArgumentNullException("Error occurred while deleteing subcategory Record");
        //    }

        //    return 1;
        //}
    }
}
