using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class SalesReceipt
    {
        public long Id { get; set; }
        public long ReceiptNo { get; set; }
        public Nullable<long> SalesOrderNo { get; set; }
        public System.DateTime ReceiptDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public virtual SalesOrder SalesOrder { get; set; }
    }
}
