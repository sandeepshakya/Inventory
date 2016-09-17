using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class SalesReceiptMap : EntityTypeConfiguration<SalesReceipt>
    {
        public SalesReceiptMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Status)
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("SalesReceipts");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ReceiptNo).HasColumnName("ReceiptNo");
            this.Property(t => t.SalesOrderNo).HasColumnName("SalesOrderNo");
            this.Property(t => t.ReceiptDate).HasColumnName("ReceiptDate");
            this.Property(t => t.TotalAmount).HasColumnName("TotalAmount");
            this.Property(t => t.Status).HasColumnName("Status");

            // Relationships
            this.HasOptional(t => t.SalesOrder)
                .WithMany(t => t.SalesReceipts)
                .HasForeignKey(d => d.SalesOrderNo);

        }
    }
}
