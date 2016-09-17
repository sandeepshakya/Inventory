using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model.Models;
using Vm = Service.ViewModel;

namespace Service
{
    interface IProductService
    {
        long UpdateSave(Product model, long id);
        IReadOnlyDictionary<long, string> ProductListForDropDown(long companyId);
        bool CheckDuplicate(long categoryId, long companyId, string name, long id);
        IReadOnlyList<Vm.Product> GetProductList(long comoanyId);
        Product GetProductById(long id, long companyId);
        int UpdateStock(List<Vm.Product> viewModel, InventoryContext dbContxt);
        int Delete(long id);
    }
}
