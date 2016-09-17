using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class SalesOrderMap : EntityTypeConfiguration<SalesOrder>
    {
        public SalesOrderMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Status)
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("SalesOrder");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CompanyId).HasColumnName("CompanyId");
            this.Property(t => t.VendorId).HasColumnName("VendorId");
            this.Property(t => t.OrderDate).HasColumnName("OrderDate");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.TotalPrice).HasColumnName("TotalPrice");
        }
    }
}
