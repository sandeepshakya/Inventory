using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class Company
    {
        public Company()
        {
            this.AutoCustomIDs = new List<AutoCustomID>();
            this.CompanyGroups = new List<CompanyGroup>();
            this.Customers = new List<Customer>();
            this.ProductCategories = new List<ProductCategory>();
            this.Products = new List<Product>();
            this.PurchaseOrders = new List<PurchaseOrder>();
            this.Vendors = new List<Vendor>();
        }

        public long Id { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public string PrimaryContactName { get; set; }
        public string Desc { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public int LicenceNo { get; set; }
        public string Image { get; set; }
        public bool IsApplicable { get; set; }
        public bool IsImageExist { get; set; }
        public string Status { get; set; }
        public virtual ICollection<AutoCustomID> AutoCustomIDs { get; set; }
        public virtual ICollection<CompanyGroup> CompanyGroups { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}
