using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ViewModel
{
    public class PoInvoice
    {
        public int SlNumber { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal GrandTotal { get; set; }
        public string PoNumber { get; set; }
        public string Vendor { get; set; }
        public string PurchasedBy { get; set; }
        public DateTime InvDate { get; set; }
        public string SupplierPhone { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierAddress { get; set; }
    }
}
