using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class PurchaseOrderMap : EntityTypeConfiguration<PurchaseOrder>
    {
        public PurchaseOrderMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Desc)
                .HasMaxLength(250);

            this.Property(t => t.Status)
                .HasMaxLength(20);

            this.Property(t => t.Number)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("PurchaseOrders");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.VendorId).HasColumnName("VendorId");
            this.Property(t => t.CompanyId).HasColumnName("CompanyId");
            this.Property(t => t.OrderDate).HasColumnName("OrderDate");
            this.Property(t => t.ShippingDate).HasColumnName("ShippingDate");
            this.Property(t => t.DueDate).HasColumnName("DueDate");
            this.Property(t => t.ReceivalDate).HasColumnName("ReceivalDate");
            this.Property(t => t.OrderedQty).HasColumnName("OrderedQty");
            this.Property(t => t.ReceivedQty).HasColumnName("ReceivedQty");
            this.Property(t => t.Desc).HasColumnName("Desc");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.TotalAmount).HasColumnName("TotalAmount");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Number).HasColumnName("Number");

            // Relationships
            this.HasOptional(t => t.Company)
                .WithMany(t => t.PurchaseOrders)
                .HasForeignKey(d => d.CompanyId);
            this.HasOptional(t => t.Vendor)
                .WithMany(t => t.PurchaseOrders)
                .HasForeignKey(d => d.VendorId);

        }
    }
}
