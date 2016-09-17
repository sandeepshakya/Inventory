using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class PurchaseOrder
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public Nullable<long> VendorId { get; set; }
        public Nullable<long> CompanyId { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.DateTime ShippingDate { get; set; }
        public System.DateTime DueDate { get; set; }
        public System.DateTime ReceivalDate { get; set; }
        public int OrderedQty { get; set; }
        public int ReceivedQty { get; set; }
        public string Desc { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public string Number { get; set; }
        public virtual Company Company { get; set; }
        public virtual Product Product { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
