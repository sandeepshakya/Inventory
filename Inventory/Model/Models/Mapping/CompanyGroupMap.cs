using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class CompanyGroupMap : EntityTypeConfiguration<CompanyGroup>
    {
        public CompanyGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("CompanyGroups");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CompanyId).HasColumnName("CompanyId");
            this.Property(t => t.GroupName).HasColumnName("GroupName");
            this.Property(t => t.ReadList).HasColumnName("ReadList");
            this.Property(t => t.WriteList).HasColumnName("WriteList");
            this.Property(t => t.ModifyList).HasColumnName("ModifyList");
            this.Property(t => t.ApprovalList).HasColumnName("ApprovalList");
            this.Property(t => t.UserIdList).HasColumnName("UserIdList");
            this.Property(t => t.CurrentUser).HasColumnName("CurrentUser");

            // Relationships
            this.HasOptional(t => t.Company)
                .WithMany(t => t.CompanyGroups)
                .HasForeignKey(d => d.CompanyId);

        }
    }
}
