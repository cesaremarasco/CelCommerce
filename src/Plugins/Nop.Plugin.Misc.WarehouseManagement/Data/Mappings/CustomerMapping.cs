using Nop.Plugin.Misc.WarehouseManagement.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Nop.Plugin.Misc.WarehouseManagement.Data.Mappings
{
    public class CustomerMapping 
        : EntityTypeConfiguration<Customer>
    {
        public CustomerMapping()
        {
            ToTable("Customer");
            HasKey(c => c.Id);            
        }
    }
}


