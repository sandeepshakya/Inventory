using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class SubCategory
    {
        public SubCategory()
        {
            this.Products = new List<Product>();
        }

        public long Id { get; set; }
        public long CategoryId { get; set; }
        public string Name { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
