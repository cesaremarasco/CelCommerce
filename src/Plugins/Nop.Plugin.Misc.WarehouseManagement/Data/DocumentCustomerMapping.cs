using Nop.Plugin.Misc.WarehouseManagement.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Nop.Plugin.Misc.WarehouseManagement.Data
{
    public class DocumentCustomerMapping : EntityTypeConfiguration<DocumentCustomer>
    {
        public DocumentCustomerMapping()
        {
            HasKey(t => new { t.Customer_Id, t.Document_Id });            
            ToTable("Wm_Document_Customer_Mapping");

            Property(t => t.Priority).IsRequired();           
        }
    }
}
