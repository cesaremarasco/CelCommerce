using Nop.Plugin.Misc.WarehouseManagement.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nop.Plugin.Misc.WarehouseManagement.Data.Mappings
{
    public class DocumentMapping : EntityTypeConfiguration<Document>
    {
        public DocumentMapping()
        {
            HasKey(t => new { t.Id });
            ToTable("Wm_Document");

            Property(t => t.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.DocumentNumber).HasMaxLength(25);
                        
            HasMany(e => e.Customers).WithRequired(e => e.Document).WillCascadeOnDelete(false);
            HasMany(e => e.Rows).WithRequired(e => e.Document).WillCascadeOnDelete(false);

            HasMany(e => e.TrasformedFrom).WithRequired(e => e.FromDocument).HasForeignKey(e => e.Id).WillCascadeOnDelete(false);
            HasMany(e => e.TrasformedTo).WithRequired(e => e.ToDocument).HasForeignKey(e => e.ChildDocument_Id).WillCascadeOnDelete(false);


            HasMany(e => e.DocumentAttributeValues).WithRequired(e => e.Wm_Document).HasForeignKey(e => e.Id).WillCascadeOnDelete(false);
           
        }
    }
}
