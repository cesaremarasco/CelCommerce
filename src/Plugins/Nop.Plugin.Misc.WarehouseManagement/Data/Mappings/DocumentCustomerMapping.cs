using Nop.Plugin.Misc.WarehouseManagement.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nop.Plugin.Misc.WarehouseManagement.Data.Mappings
{
    public class DocumentCustomerMapping : EntityTypeConfiguration<DocumentCustomer>
    {
        public DocumentCustomerMapping()
        {
            HasKey(t => new { t.Id, t.Customer_Id });

            ToTable("Wm_Document_Customer_Mapping");

            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(t => t.Customer_Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(t => t.Priority).IsRequired();
        }
    }
}
