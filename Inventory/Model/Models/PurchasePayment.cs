using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class PurchasePayment
    {
        public int Id { get; set; }
        public Nullable<long> OrderId { get; set; }
        public Nullable<long> VendorId { get; set; }
        public System.DateTime DatePaid { get; set; }
        public decimal TotalAmntPaid { get; set; }
        public decimal BalanceRemaining { get; set; }
        public decimal Tax { get; set; }
        public Nullable<long> ClientId { get; set; }
        public string ReceiveId { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
