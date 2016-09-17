using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class SysAdminMap : EntityTypeConfiguration<SysAdmin>
    {
        public SysAdminMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Status)
                .HasMaxLength(50);

            this.Property(t => t.UserName)
                .HasMaxLength(50);

            this.Property(t => t.Password)
                .HasMaxLength(50);

            this.Property(t => t.UserType)
                .HasMaxLength(50);

            this.Property(t => t.OperateType)
                .HasMaxLength(50);

            this.Property(t => t.CompanyIdList)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SysAdmin");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CompanyId).HasColumnName("CompanyId");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.NoofLicence).HasColumnName("NoofLicence");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.UserType).HasColumnName("UserType");
            this.Property(t => t.OperateType).HasColumnName("OperateType");
            this.Property(t => t.CompanyIdList).HasColumnName("CompanyIdList");

            // Relationships
            this.HasRequired(t => t.SysAdmin2)
                .WithOptional(t => t.SysAdmin1);

        }
    }
}
