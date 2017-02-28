using Nop.Plugin.Misc.WarehouseManagement.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nop.Plugin.Misc.WarehouseManagement.Data.Mappings
{
    public class DocumentRowMapping :
        EntityTypeConfiguration<DocumentRow>
    {
        public DocumentRowMapping()
        {
            HasKey(t => new { t.Id,t.RowNumber });
            ToTable("Wm_DocumentRow");

            Property(t => t.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(t => t.RowNumber).HasColumnName("RowNumber").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.ProductDescription).HasMaxLength(100);
            Property(t => t.ExtProductDescription).HasColumnType("ntext");
            Property(t => t.Um1).HasMaxLength(20);
            Property(t => t.Um2).HasMaxLength(20);
            Property(t => t.Price1).HasColumnType("money");
            Property(t => t.Price1).HasPrecision(19, 4);
            Property(t => t.Price2).HasColumnType("money");
            Property(t => t.Price2).HasPrecision(19, 4);
            Property(t => t.Discount1).HasColumnType("money");
            Property(t => t.Discount1).HasPrecision(19, 4);
            Property(t => t.Discount2).HasColumnType("money");
            Property(t => t.Discount2).HasPrecision(19, 4);
            Property(t => t.Note).HasColumnType("ntext");
        }
    }
}
