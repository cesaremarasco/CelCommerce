using System.Collections.Generic;

namespace Nop.Plugin.Misc.WarehouseManagement.Models
{
    public class DocumentContainerModel
    {
        public DocumentContainerModel()
        {
            PaymentMethods = new List<DocumentAspectModel>();
            ShippingProviders = new List<DocumentAspectModel>();
            Document = new DocumentModel();            
        }
        public DocumentModel Document { get; set; }
        public IList<DocumentAspectModel> PaymentMethods { get; set; }
        public IList<DocumentAspectModel> ShippingProviders { get; set; }  
    }
}