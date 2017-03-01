using Nop.Plugin.Misc.WarehouseManagement.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Nop.Plugin.Misc.WarehouseManagement.Data.Mappings
{   
    public class CustomerRoleMapping : EntityTypeConfiguration<CustomerRole>
    {
        public CustomerRoleMapping()
        {
            ToTable("CustomerRole");
            HasKey(cr => cr.Id);
            this.Property(cr => cr.Name).IsRequired().HasMaxLength(255);            
        }
    }
}
