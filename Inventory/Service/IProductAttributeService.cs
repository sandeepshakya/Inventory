using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
namespace Service
{
    interface IProductAttributeService
    {
        long UpdateSave(ProductAttribute model, long id);
        IReadOnlyList<ProductAttribute> GetAllProductList(long productId);
        ProductAttribute GetAllAttributesById(long id);
        bool CheckDuplicate(string name, long productId);
    }
}
