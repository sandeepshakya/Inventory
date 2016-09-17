using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class VendorMap : EntityTypeConfiguration<Vendor>
    {
        public VendorMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Vendors");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.Address2).HasColumnName("Address2");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.Office).HasColumnName("Office");
            this.Property(t => t.Fax).HasColumnName("Fax");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Website).HasColumnName("Website");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.CompanyId).HasColumnName("CompanyId");
            this.Property(t => t.IsApplicable).HasColumnName("IsApplicable");
            this.Property(t => t.UserName).HasColumnName("UserName");

            // Relationships
            this.HasRequired(t => t.Company)
                .WithMany(t => t.Vendors)
                .HasForeignKey(d => d.CompanyId);

        }
    }
}
