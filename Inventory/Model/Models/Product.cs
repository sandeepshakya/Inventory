using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class Product
    {
        public Product()
        {
            this.ProductAttributes = new List<ProductAttribute>();
            this.ProductUnits = new List<ProductUnit>();
            this.PurchaseOrders = new List<PurchaseOrder>();
        }

        public long Id { get; set; }
        public string Number { get; set; }
        public long CategoryId { get; set; }
        public Nullable<long> SubCategoryId { get; set; }
        public string ProductName { get; set; }
        public int AttributeId { get; set; }
        public string Value { get; set; }
        public long LocationId { get; set; }
        public decimal ProductCost { get; set; }
        public long CompanyId { get; set; }
        public bool IsImageExist { get; set; }
        public bool IsApplicable { get; set; }
        public string ObjName { get; set; }
        public string UserName { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string ImageUrl { get; set; }
        public Nullable<int> NotifyLowQuantity { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<ProductAttribute> ProductAttributes { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ProductLocation ProductLocation { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public virtual ICollection<ProductUnit> ProductUnits { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
