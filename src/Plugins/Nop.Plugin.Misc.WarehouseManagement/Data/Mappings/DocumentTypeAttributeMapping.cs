using Nop.Plugin.Misc.WarehouseManagement.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Nop.Plugin.Misc.WarehouseManagement.Data.Mappings
{
    public class DocumentTypeAttributeMapping : EntityTypeConfiguration<DocumentTypeAttribute>
    {
        public DocumentTypeAttributeMapping()
        {
            ToTable("Wm_DocumentTypeAttribute");
            HasKey(cr => cr.Id);

            Property(cr => cr.Name).IsRequired()
                                        .HasMaxLength(400);

            HasMany(e => e.DocumentAttributeValues).WithRequired(e => e.Wm_DocumentAttribute).HasForeignKey(e => e.DocumentAttribute_Id).WillCascadeOnDelete(false);
        }
    }
}