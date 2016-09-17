using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class ProductUnitMap : EntityTypeConfiguration<ProductUnit>
    {
        public ProductUnitMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.UnitName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductUnits");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UnitName).HasColumnName("UnitName");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.ClientId).HasColumnName("ClientId");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductUnits)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
