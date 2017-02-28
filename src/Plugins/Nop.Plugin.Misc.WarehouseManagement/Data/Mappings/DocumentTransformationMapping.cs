using Nop.Plugin.Misc.WarehouseManagement.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nop.Plugin.Misc.WarehouseManagement.Data.Mappings
{
    public class DocumentTransformationMapping 
        : EntityTypeConfiguration<DocumentTransformation>
    {
        public DocumentTransformationMapping()
        {
            HasKey(t => new { t.Id, t.ChildDocument_Id });
            ToTable("Wm_DocumentTransformation");

            Property(t => t.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(t => t.ChildDocument_Id).HasColumnName("RowNumber").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Customer_Id).IsRequired();
            Property(t => t.TransformationDate).IsRequired();   
        }
    }
}
