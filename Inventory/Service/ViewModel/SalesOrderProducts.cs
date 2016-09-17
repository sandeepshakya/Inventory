using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ViewModel
{
    public class SalesOrderProducts
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
        public decimal GrandTotal { get; set; }
        public string Buyer { get; set; }
        public DateTime OrderDate { get; set; }
        public string ProductCode { get; set; }
        public string ShippingAddress { get; set; }
        public string SONumber { get; set; }
        public string Status { get; set; }
        public string PaymentMode { get; set; }
        public string PONumber { get; set; }
        public string BuyerPhone { get; set; }
        public string BuyerEmail { get; set; }
    }
}
