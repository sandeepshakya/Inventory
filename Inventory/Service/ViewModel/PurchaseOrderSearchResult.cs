using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ViewModel
{
    public class PurchaseOrderSearchResult
    {
        public long Id { get; set; }
        public string PoNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderQty { get; set; }
        public decimal GrandTotal { get; set; }
        public string Vendor { get; set; }
        public string PurchasedBy { get; set; }
    }
}
