using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Service
{
    interface IVendorService
    {
        long UpdateSave(Vendor model, long id);
        long Delete(long id);
        bool CheckDuplicate(string vendorName, long companyId, long id);
        IReadOnlyDictionary<long, string> GetVendorListForDropDown(long companyId);
        IReadOnlyList<Vendor> GetVendorList(long companyId);
        Vendor GetVendorById(long id);
       
    }
}
