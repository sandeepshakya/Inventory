using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductAttributeService : IProductAttributeService
    {
        public long UpdateSave(ProductAttribute model, long id)
        {
            using (var dbContxt = new InventoryContext())
            {
                var dbModel = id > 0 ? dbContxt.ProductAttributes.Find(id) : dbContxt.ProductAttributes.Add(model);
                if (id > 0)
                {
                    dbModel.AttributeName = model.AttributeName;
                    dbModel.ProductId = model.ProductId;

                }
                if (dbContxt.SaveChanges() > 0)
                    return dbModel.Id;

                return dbModel.Id;
            }
        }

        public IReadOnlyList<ProductAttribute> GetAllProductList(long productId)
        {
            using (var dbCntxt = new InventoryContext())
            {
                return dbCntxt.ProductAttributes.Where(cm => cm.ProductId == productId)
                    .ToList();
            }
        }

        public ProductAttribute GetAllAttributesById(long id)
        {
            using (var dbCntxt = new InventoryContext())
            {
                return dbCntxt.ProductAttributes.Find(id);
            }
        }

        public bool CheckDuplicate(string name, long productId)
        {
            using (var dbCntxt = new InventoryContext())
            {
                return dbCntxt.ProductAttributes
                    .Any(att => att.ProductId == productId
                    && att.AttributeName.ToLower() == name.ToLower());
            }
        }
    }
}
