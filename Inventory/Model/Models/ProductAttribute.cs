using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class ProductAttribute
    {
        public long Id { get; set; }
        public string AttributeName { get; set; }
        public long ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
