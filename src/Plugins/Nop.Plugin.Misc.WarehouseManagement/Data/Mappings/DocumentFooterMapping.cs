using Nop.Plugin.Misc.WarehouseManagement.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nop.Plugin.Misc.WarehouseManagement.Data.Mappings
{
    public class DocumentFooterMapping 
        : EntityTypeConfiguration<DocumentFooter>
    {
        public DocumentFooterMapping()
        {
            HasKey(t => new { t.Id });

            ToTable("Wm_DocumentFooter");

            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None); 
                
            Property(t => t.PaymentCode).HasMaxLength(10);
            Property(t => t.PaymentDescr).HasMaxLength(100);
            Property(t => t.PaymentStatus).HasMaxLength(20);

            HasOptional(e => e.Document).WithRequired(e => e.Footer);
        }
    }
}
