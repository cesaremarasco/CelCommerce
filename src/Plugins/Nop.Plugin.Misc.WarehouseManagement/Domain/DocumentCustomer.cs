using Nop.Core.Domain.Customers;

namespace Nop.Plugin.Misc.WarehouseManagement.Domain
{
    public class DocumentCustomer
    {
        public int Document_Id { get; set; }
        public int Customer_Id { get; set; }
        public int Priority { get; set; }
        public Customer Customer { get; set; }
        public Document Document { get; set; }
    }
}
