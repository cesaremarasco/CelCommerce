using Nop.Plugin.Misc.WarehouseManagement.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nop.Plugin.Misc.WarehouseManagement.Data.Mappings
{
    public class DocumentAttributeValueMapping 
        : EntityTypeConfiguration<DocumentAttributeValue>
    {
        public DocumentAttributeValueMapping()
        {
            ToTable("Wm_Document_DocumentTypeAttribute_Mapping");   
            HasKey(t => new { t.Id, t.DocumentAttribute_Id });           

            Property(t => t.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(t => t.DocumentAttribute_Id).HasColumnName("DocumentAttribute_Id ").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
           
        }
    }
}