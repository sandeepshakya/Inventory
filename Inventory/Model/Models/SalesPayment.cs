using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class SalesPayment
    {
        public long Id { get; set; }
        public long SalesOrderNo { get; set; }
        public System.DateTime PaidDate { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public long CompanyId { get; set; }
        public virtual SalesOrder SalesOrder { get; set; }
    }
}
