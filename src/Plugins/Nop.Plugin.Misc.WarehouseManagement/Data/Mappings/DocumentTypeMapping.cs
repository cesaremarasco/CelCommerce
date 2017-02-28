using Nop.Plugin.Misc.WarehouseManagement.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nop.Plugin.Misc.WarehouseManagement.Data.Mappings
{
    public class DocumentTypeMapping : EntityTypeConfiguration<DocumentType>
    {
        public DocumentTypeMapping()
        {
            HasKey(t => new { t.Id });

            ToTable("Wm_DocumentType");

            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Code).HasMaxLength(20);
            Property(t => t.Code).IsRequired();

            Property(t => t.Description).HasMaxLength(100);
            Property(t => t.Description).IsRequired();

            HasMany(e => e.Document).WithOptional(e => e.DocumentType).HasForeignKey(e => e.DocumentType_Id);

            HasMany(e => e.TrasformationParentDocuments)
                  .WithMany(e => e.TrasformationChildDocuments)
                  .Map(m => m.ToTable("Wm_DocumentTypeTransformation")
                  .MapLeftKey("Id")
                  .MapRightKey("DocumentChild_Id"));
        }
    }
}
