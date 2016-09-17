using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class GroupUserMap : EntityTypeConfiguration<GroupUser>
    {
        public GroupUserMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("GroupUsers");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.GroupId).HasColumnName("GroupId");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.CompanyId).HasColumnName("CompanyId");
            this.Property(t => t.DesigId).HasColumnName("DesigId");
            this.Property(t => t.DeptId).HasColumnName("DeptId");
            this.Property(t => t.UserType).HasColumnName("UserType");
            this.Property(t => t.UserStatus).HasColumnName("UserStatus");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Qualification).HasColumnName("Qualification");
            this.Property(t => t.PresentAddress).HasColumnName("PresentAddress");
            this.Property(t => t.PresentCity).HasColumnName("PresentCity");
            this.Property(t => t.PresentSate).HasColumnName("PresentSate");
            this.Property(t => t.MobileNumber).HasColumnName("MobileNumber");
            this.Property(t => t.PermanentAddress).HasColumnName("PermanentAddress");
            this.Property(t => t.PermanentCity).HasColumnName("PermanentCity");
            this.Property(t => t.PermanentState).HasColumnName("PermanentState");
            this.Property(t => t.PermanentPhoneNumber).HasColumnName("PermanentPhoneNumber");
            this.Property(t => t.PermanentMobileNumber).HasColumnName("PermanentMobileNumber");
            this.Property(t => t.SignaturePath).HasColumnName("SignaturePath");
            this.Property(t => t.IsApplicable).HasColumnName("IsApplicable");
            this.Property(t => t.SubmittedBy).HasColumnName("SubmittedBy");
            this.Property(t => t.SubmissionDate).HasColumnName("SubmissionDate");
            this.Property(t => t.IsImageExist).HasColumnName("IsImageExist");

            // Relationships
            this.HasRequired(t => t.GroupUser1)
                .WithMany(t => t.GroupUsers1)
                .HasForeignKey(d => d.GroupId);

        }
    }
}
