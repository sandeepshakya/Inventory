using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ViewModel
{
    public class SoInvoice : PoInvoice
    {
        public int? ApprovedQty { get; set; }
        public int? AvailableQty { get; set; }
        public string ShippingAddress { get; set; }
        public decimal TotalPrice { get; set; }
        public string SoNumber { get; set; }
        public string Status { get; set; }
        public string PaymentMode { get; set; }
        public string OrderedQty { get; set; }
    }
}
