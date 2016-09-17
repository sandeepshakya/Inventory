using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class ProductCategoryMap : EntityTypeConfiguration<ProductCategory>
    {
        public ProductCategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("ProductCategories");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.CompanyId).HasColumnName("CompanyId");
            this.Property(t => t.UserName).HasColumnName("UserName");

            // Relationships
            this.HasRequired(t => t.Company)
                .WithMany(t => t.ProductCategories)
                .HasForeignKey(d => d.CompanyId);

        }
    }
}
