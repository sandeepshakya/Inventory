using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    interface ICategoryService
    {
        long UpdateSave(ProductCategory model, long id);
        IReadOnlyDictionary<long, string> GetCategoryListForDropdown(long companyId);
        IReadOnlyList<ProductCategory> GetCategoryList(long companyId);
        ProductCategory GetCategoryById(long id);
        bool CheckDuplicate(long companyId, string name, long id);
               int Delete(long id);

    }
}
