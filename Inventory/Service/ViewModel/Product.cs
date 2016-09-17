using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ViewModel
{
    public class Product
    {
        public long Id { get; set; }
        public string Number { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string ProductName { get; set; }
        public string Location { get; set; }
        public decimal ProductCost { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl { get; set; }
        public int NotifyLowQuantity { get; set; }
    }
}
