using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class ProductUnit
    {
        public long Id { get; set; }
        public string UnitName { get; set; }
        public long ProductId { get; set; }
        public Nullable<long> ClientId { get; set; }
        public virtual Product Product { get; set; }
    }
}
