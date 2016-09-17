using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class ProductLocationMap : EntityTypeConfiguration<ProductLocation>
    {
        public ProductLocationMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("ProductLocations");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Locaton).HasColumnName("Locaton");
        }
    }
}
