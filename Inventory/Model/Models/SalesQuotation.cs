using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class SalesQuotation
    {
        public long Id { get; set; }
        public int QuotationNo { get; set; }
        public Nullable<long> CustomerId { get; set; }
        public System.DateTime QuotationDate { get; set; }
        public string PricingScheme { get; set; }
        public string PaymentMode { get; set; }
        public string TaxScheme { get; set; }
        public string QuotApproved { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
