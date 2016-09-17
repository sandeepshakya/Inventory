using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class Vendor
    {
        public Vendor()
        {
            this.PurchaseOrders = new List<PurchaseOrder>();
            this.PurchasePayments = new List<PurchasePayment>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Mobile { get; set; }
        public string Office { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string City { get; set; }
        public long CompanyId { get; set; }
        public bool IsApplicable { get; set; }
        public string UserName { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<PurchasePayment> PurchasePayments { get; set; }
        public virtual ICollection<SalesOrder> SalesOrder { get; set; }
    }
}
