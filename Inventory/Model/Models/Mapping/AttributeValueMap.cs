using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class AttributeValueMap : EntityTypeConfiguration<AttributeValue>
    {
        public AttributeValueMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("AttributeValues");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AttributeId).HasColumnName("AttributeId");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.ValueId).HasColumnName("ValueId");
        }
    }
}
