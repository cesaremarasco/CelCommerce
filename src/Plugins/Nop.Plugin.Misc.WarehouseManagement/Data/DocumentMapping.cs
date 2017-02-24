using Nop.Plugin.Misc.WarehouseManagement.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nop.Plugin.Misc.WarehouseManagement.Data
{
    public class DocumentMapping : EntityTypeConfiguration<Document>
    {
        public DocumentMapping()
        {
            HasKey(t => new { t.Id });
            ToTable("Wm_Document");

            Property(t => t.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.DocumentNumber).HasMaxLength(25);
            
           
          
            //Property(t => t.IdTipoDocumento).HasColumnName("IdTipoDocumento");

            //Property(t => t.Anno).HasColumnName("Anno").IsRequired();
            //Property(t => t.NumeroDocumento).HasColumnName("NumeroDocumento").IsUnicode(false).HasMaxLength(20);
            //Property(t => t.DataRegistrazione).HasColumnName("DataRegistrazione").HasColumnType("datetime2");
            //Property(t => t.DataDocumento).HasColumnName("DataDocumento").HasColumnType("datetime2");
            //Property(t => t.DataFineValidita).HasColumnName("DataFineValidita").HasColumnType("datetime2");
            //Property(t => t.DataUltimaMod).HasColumnName("DataUltimaMod").HasColumnType("datetime2");
            //Property(t => t.Utente).HasColumnName("Utente").IsUnicode(false).HasMaxLength(50);
            //Property(t => t.Trasformato).HasColumnName("Trasformato");
            //Property(t => t.Stato).HasColumnName("Stato");
            //Property(t => t.DataUltimaEmail).HasColumnName("DataUltimaEmail").HasColumnType("datetime2");
            //Property(t => t.Note).HasColumnName("Note");

            //HasRequired(t => t.TipoDocumentoObj).WithMany(t => t.Documenti).HasForeignKey(d => new { d.IdTipoDocumento, d.IdAzienda }).WillCascadeOnDelete(false);
           
            //HasOptional(x => x.TotaleDocumentoObj).WithRequired();
          
        }
    }
}
