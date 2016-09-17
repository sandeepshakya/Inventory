using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Service
{
    interface ICompanyGroupService
    {
        long UpdateSave(CompanyGroup model, long id);
        IReadOnlyDictionary<long, string> GetGroupListForDropdown(long companyId);
        IReadOnlyList<CompanyGroup> GetGroupList(long companyId);
        ProductCategory GetGroupById(long id);
        bool CheckDuplicateGroup(long companyId, string name);
    }
}
