using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Customers");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.OfficeNo).HasColumnName("OfficeNo");
            this.Property(t => t.MobileNo).HasColumnName("MobileNo");
            this.Property(t => t.ShippingAddress).HasColumnName("ShippingAddress");
            this.Property(t => t.BilingAddress).HasColumnName("BilingAddress");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Fax).HasColumnName("Fax");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Website).HasColumnName("Website");
            this.Property(t => t.CompanyId).HasColumnName("CompanyId");
            this.Property(t => t.IsApplicable).HasColumnName("IsApplicable");
            this.Property(t => t.UserName).HasColumnName("UserName");

            // Relationships
            this.HasRequired(t => t.Company)
                .WithMany(t => t.Customers)
                .HasForeignKey(d => d.CompanyId);

        }
    }
}
