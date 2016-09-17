using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class SalesQuotationMap : EntityTypeConfiguration<SalesQuotation>
    {
        public SalesQuotationMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("SalesQuotations");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.QuotationNo).HasColumnName("QuotationNo");
            this.Property(t => t.CustomerId).HasColumnName("CustomerId");
            this.Property(t => t.QuotationDate).HasColumnName("QuotationDate");
            this.Property(t => t.PricingScheme).HasColumnName("PricingScheme");
            this.Property(t => t.PaymentMode).HasColumnName("PaymentMode");
            this.Property(t => t.TaxScheme).HasColumnName("TaxScheme");
            this.Property(t => t.QuotApproved).HasColumnName("QuotApproved");

            // Relationships
            this.HasOptional(t => t.Customer)
                .WithMany(t => t.SalesQuotations)
                .HasForeignKey(d => d.CustomerId);

        }
    }
}
