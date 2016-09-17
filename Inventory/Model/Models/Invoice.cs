using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class Invoice
    {
        public long Id { get; set; }
        public long CustomerId { get; set; }
        public System.DateTime Date { get; set; }
        public decimal PaymentAmount { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
