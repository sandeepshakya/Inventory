using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class SalesOrder
    {
        public SalesOrder()
        {
            this.SalesPayments = new List<SalesPayment>();
            this.SalesReceipts = new List<SalesReceipt>();
        }

        public long Id { get; set; }
        public Nullable<long> CompanyId { get; set; }
        public Nullable<long> VendorId { get; set; }
        public string PONumber { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public string Status { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public int? RequestedQnty { get; set; }
        public int? ApprovedQnty { get; set; }
        public string Number { get; set; }
        public string PaymentMode { get; set; }
        public string Comments { get; set; }
        public virtual ICollection<SalesPayment> SalesPayments { get; set; }
        public virtual ICollection<SalesReceipt> SalesReceipts { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
