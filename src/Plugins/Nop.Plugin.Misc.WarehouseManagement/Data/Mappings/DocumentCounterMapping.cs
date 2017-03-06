using Nop.Plugin.Misc.WarehouseManagement.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
namespace Nop.Plugin.Misc.WarehouseManagement.Data.Mappings
{
    public class DocumentCounterMapping : EntityTypeConfiguration<DocumentCounter>
    {
        public DocumentCounterMapping()
        {
            ToTable("Wm_DocumentCounter");
            HasKey(c => c.Id);
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}