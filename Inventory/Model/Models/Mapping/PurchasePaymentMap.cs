using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class PurchasePaymentMap : EntityTypeConfiguration<PurchasePayment>
    {
        public PurchasePaymentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("PurchasePayments");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.VendorId).HasColumnName("VendorId");
            this.Property(t => t.DatePaid).HasColumnName("DatePaid");
            this.Property(t => t.TotalAmntPaid).HasColumnName("TotalAmntPaid");
            this.Property(t => t.BalanceRemaining).HasColumnName("BalanceRemaining");
            this.Property(t => t.Tax).HasColumnName("Tax");
            this.Property(t => t.ClientId).HasColumnName("ClientId");
            this.Property(t => t.ReceiveId).HasColumnName("ReceiveId");

            // Relationships
            this.HasOptional(t => t.Vendor)
                .WithMany(t => t.PurchasePayments)
                .HasForeignKey(d => d.VendorId);

        }
    }
}
