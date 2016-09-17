using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            this.Products = new List<Product>();
            this.SubCategories = new List<SubCategory>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long CompanyId { get; set; }
        public string UserName { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}
