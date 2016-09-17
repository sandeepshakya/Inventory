using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class AutoCustomIDMap : EntityTypeConfiguration<AutoCustomID>
    {
        public AutoCustomIDMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("AutoCustomIDs");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CompanyId).HasColumnName("CompanyId");
            this.Property(t => t.ObjectName).HasColumnName("ObjectName");
            this.Property(t => t.IDType).HasColumnName("IDType");
            this.Property(t => t.NoOfCharacter).HasColumnName("NoOfCharacter");
            this.Property(t => t.StartingChar).HasColumnName("StartingChar");
            this.Property(t => t.StartingSequence).HasColumnName("StartingSequence");
            this.Property(t => t.IncrementNo).HasColumnName("IncrementNo");
            this.Property(t => t.UserName).HasColumnName("UserName");

            // Relationships
            this.HasOptional(t => t.Company)
                .WithMany(t => t.AutoCustomIDs)
                .HasForeignKey(d => d.CompanyId);

        }
    }
}
