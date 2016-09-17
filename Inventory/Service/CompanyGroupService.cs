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
    public class CompanyGroupService : ICompanyGroupService
    {
        public long UpdateSave(CompanyGroup model, long id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyDictionary<long, string> GetGroupListForDropdown(long companyId)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<CompanyGroup> GetGroupList(long companyId)
        {
            throw new NotImplementedException();
        }

        public ProductCategory GetGroupById(long id)
        {
            throw new NotImplementedException();
        }

        public bool CheckDuplicateGroup(long companyId, string name)
        {
            throw new NotImplementedException();
        }
    }
}
