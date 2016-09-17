using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class Customer
    {
        public Customer()
        {
            this.Invoices = new List<Invoice>();
            this.SalesQuotations = new List<SalesQuotation>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string OfficeNo { get; set; }
        public string MobileNo { get; set; }
        public string ShippingAddress { get; set; }
        public string BilingAddress { get; set; }
        public string City { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public long CompanyId { get; set; }
        public bool IsApplicable { get; set; }
        public string UserName { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<SalesQuotation> SalesQuotations { get; set; }
    }
}
