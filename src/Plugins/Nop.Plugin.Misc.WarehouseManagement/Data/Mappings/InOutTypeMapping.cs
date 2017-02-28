using Nop.Plugin.Misc.WarehouseManagement.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nop.Plugin.Misc.WarehouseManagement.Data.Mappings
{
    public class InOutTypeMapping 
        : EntityTypeConfiguration<InOutType>
    {
        public InOutTypeMapping()
        {
            HasKey(t => new { t.Id });

            ToTable("Wm_InOutType");

            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(t => t.Description).HasMaxLength(20);

            HasMany(e => e.DocumentTypes).WithRequired(e => e.InOutType).HasForeignKey(e => e.InOutType_Id) .WillCascadeOnDelete(false);
        }
    }
}
