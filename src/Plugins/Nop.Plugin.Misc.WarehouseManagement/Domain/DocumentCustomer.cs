using Nop.Core;

namespace Nop.Plugin.Misc.WarehouseManagement.Domain
{
    public class DocumentCustomer 
        : BaseEntity
    {     
        public int Customer_Id { get; set; }
        public int Priority { get; set; }       
        public Document Document { get; set; }       
    }
}
