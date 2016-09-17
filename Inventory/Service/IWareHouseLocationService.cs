using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Service
{
    interface IWareHouseLocationService
    {
        long UpdateSave(ProductLocation model, long id);
        IReadOnlyDictionary<long, string> LocationListForDropDown();
        bool CheckDuplicate(string name, long id);
        IReadOnlyCollection<ProductLocation> SearchResult();
        ProductLocation GetById(long id);
        int Delete(long id);
    }
}
