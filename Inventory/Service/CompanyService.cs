using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model.Models;
using Vm = Service.ViewModel;
using System.Data.Entity;
namespace Service
{
    public class CompanyService : ICompanyService
    {
        public long UpdateSave(Company model, long id)
        {
            using (var dbContxt = new InventoryContext())
            {
                var dbModel = id > 0 ? dbContxt.Companies.Find(id) : dbContxt.Companies.Add(model);
                if (id > 0)
                {
                    dbModel.Address = model.Address;
                    dbModel.City = model.City;
                    dbModel.ContactNo = model.ContactNo;
                    dbModel.Country = model.Country;
                    dbModel.Desc = model.Desc;
                    dbModel.Email = model.Email;
                    dbModel.Image = model.Image;
                    dbModel.IsImageExist = model.IsImageExist;
                    dbModel.LicenceNo = model.LicenceNo;
                    dbModel.Name = model.Name;
                    dbModel.PrimaryContactName = model.PrimaryContactName;
                    dbModel.Size = model.Size;
                    dbModel.State = model.State;
                    dbModel.Status = model.Status;
                    dbModel.Vendors = model.Vendors;
                    dbModel.Website = model.Website;
                    dbModel = model;
                    dbContxt.Entry(dbModel).State = EntityState.Modified;
                }

                if (dbContxt.SaveChanges() > 0)
                    return dbModel.Id;

                return dbModel.Id;
            }
        }

        public long Delete(long id)
        {
            using (var dbContxt = new InventoryContext())
            {
                var dbModel = dbContxt.Companies.Find(id);
                dbContxt.Entry(dbModel).State = System.Data.Entity.EntityState.Deleted;

                if (dbContxt.SaveChanges() > 0)
                    return dbModel.Id;

                return dbModel.Id;
            }
        }

        public bool CheckDuplicate(string companyName, long id)
        {
            using (var dbContxt = new InventoryContext())
            {
                return dbContxt.Companies.Any(cm => cm.Name.ToLower() == companyName.ToLower() && cm.Id != id);
            }
        }

        public IReadOnlyList<Vm.Company> Search(string status, string name)
        {
            using (var dbContxt = new InventoryContext())
            {
                var result = new List<Company>();

                if (!string.IsNullOrEmpty(name))
                    result = dbContxt.Companies.AsNoTracking().
                          Where(cm => cm.Status == status && cm.Name.StartsWith(name)).ToList();

                if (string.IsNullOrEmpty(name))
                    result = dbContxt.Companies.
                          Where(cm => cm.Status == status).ToList();

                if (result.Count == 0)
                    return new List<Vm.Company>();

                return result.Select(cm => new Vm.Company
                  {
                      CompanyID = cm.Id,
                      Name = cm.Name,
                      ContactPersonName = cm.PrimaryContactName,
                      ContactNumber = cm.ContactNo,
                      Email = cm.Email,
                      City = cm.City,
                      ApprovalDate = DateTime.UtcNow,
                      NoOfLicence = 12,
                      TrialStartDate = DateTime.UtcNow.AddDays(-10),
                      TrialEndDate = DateTime.UtcNow.AddDays(20)
                  }).ToList();
            }
        }
    }
}
