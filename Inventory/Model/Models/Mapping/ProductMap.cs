using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Value)
                .HasMaxLength(250);

            this.Property(t => t.UserName)
                .HasMaxLength(10);

            this.Property(t => t.ImageUrl)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Products");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Number).HasColumnName("Number");
            this.Property(t => t.CategoryId).HasColumnName("CategoryId");
            this.Property(t => t.SubCategoryId).HasColumnName("SubCategoryId");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.AttributeId).HasColumnName("AttributeId");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.ProductCost).HasColumnName("ProductCost");
            this.Property(t => t.CompanyId).HasColumnName("CompanyId");
            this.Property(t => t.IsImageExist).HasColumnName("IsImageExist");
            this.Property(t => t.IsApplicable).HasColumnName("IsApplicable");
            this.Property(t => t.ObjName).HasColumnName("ObjName");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.ImageUrl).HasColumnName("ImageUrl");
            this.Property(t => t.NotifyLowQuantity).HasColumnName("NotifyLowQuantity");

            // Relationships
            this.HasRequired(t => t.Company)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.CompanyId);
            this.HasRequired(t => t.ProductCategory)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.CategoryId);
            this.HasRequired(t => t.ProductLocation)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.LocationId);
            this.HasOptional(t => t.SubCategory)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.SubCategoryId);

        }
    }
}
