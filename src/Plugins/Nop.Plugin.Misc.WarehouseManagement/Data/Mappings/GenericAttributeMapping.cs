using Nop.Plugin.Misc.WarehouseManagement.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Nop.Plugin.Misc.WarehouseManagement.Data.Mappings
{   

    public partial class GenericAttributeMapping : EntityTypeConfiguration<GenericAttribute>
    {
        public GenericAttributeMapping()
        {
            ToTable("GenericAttribute");
            HasKey(ga => ga.Id);
            Property(ga => ga.KeyGroup).IsRequired().HasMaxLength(400);
            Property(ga => ga.Key).IsRequired().HasMaxLength(400);
            Property(ga => ga.Value).IsRequired();
        }
    }
}
