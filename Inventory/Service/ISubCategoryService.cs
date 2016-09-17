using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Service
{
    interface ISubCategoryService
    {
        long UpdateSave(SubCategory model, long id);
        IReadOnlyDictionary<long, string> GetSubCategoryListForDropdown(long categoryId);
        SubCategory GetSubCategoryById(long id);
        bool CheckDuplicate(string name, long categoryId, long id);
        IReadOnlyList<ViewModel.SubCategory> SubCategorySearchResult();
        int Delete(long id);
    }
}
