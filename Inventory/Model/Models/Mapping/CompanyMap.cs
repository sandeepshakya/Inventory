using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class CompanyMap : EntityTypeConfiguration<Company>
    {
        public CompanyMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Companies");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Size).HasColumnName("Size");
            this.Property(t => t.PrimaryContactName).HasColumnName("PrimaryContactName");
            this.Property(t => t.Desc).HasColumnName("Desc");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.ContactNo).HasColumnName("ContactNo");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Website).HasColumnName("Website");
            this.Property(t => t.LicenceNo).HasColumnName("LicenceNo");
            this.Property(t => t.Image).HasColumnName("Image");
            this.Property(t => t.IsApplicable).HasColumnName("IsApplicable");
            this.Property(t => t.IsImageExist).HasColumnName("IsImageExist");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
