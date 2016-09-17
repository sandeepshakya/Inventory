using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class ProductLocation
    {
        public ProductLocation()
        {
            this.Products = new List<Product>();
        }

        public long Id { get; set; }
        public string Locaton { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
