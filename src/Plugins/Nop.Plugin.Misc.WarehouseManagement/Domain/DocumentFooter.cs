using Nop.Core;

namespace Nop.Plugin.Misc.WarehouseManagement.Domain
{
    public class DocumentFooter : 
        BaseEntity    { 
        public string PaymentCode { get; set; }       
        public string PaymentDescr { get; set; }        
        public string PaymentStatus { get; set; }
        public virtual Document Document { get; set; }
    }
}
