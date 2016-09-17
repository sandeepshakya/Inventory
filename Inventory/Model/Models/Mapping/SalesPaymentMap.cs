using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class SalesPaymentMap : EntityTypeConfiguration<SalesPayment>
    {
        public SalesPaymentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("SalesPayments");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.SalesOrderNo).HasColumnName("SalesOrderNo");
            this.Property(t => t.PaidDate).HasColumnName("PaidDate");
            this.Property(t => t.PaidAmount).HasColumnName("PaidAmount");
            this.Property(t => t.TotalAmount).HasColumnName("TotalAmount");
            this.Property(t => t.CompanyId).HasColumnName("CompanyId");

            // Relationships
            this.HasRequired(t => t.SalesOrder)
                .WithMany(t => t.SalesPayments)
                .HasForeignKey(d => d.SalesOrderNo);

        }
    }
}
