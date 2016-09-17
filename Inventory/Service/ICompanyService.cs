using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Service
{
    interface ICompanyService
    {
         long UpdateSave(Company model, long id);
         long Delete(long id);
         bool CheckDuplicate(string companyName, long id);
         IReadOnlyList<Service.ViewModel.Company> Search(string status, string name);
    }
}
