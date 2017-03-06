using Nop.Plugin.Misc.WarehouseManagement.Domain;
using Nop.Web.Framework.Mvc;
using System.Collections.Generic;

namespace Nop.Plugin.Misc.WarehouseManagement.Models
{
    public class DocumentModel : BaseNopEntityModel
    {
        public DocumentModel()
        {
            Entity = new Document();
            PaymentMethods = new List<DocumentAspectModel>();
            ShippingProviders = new List<DocumentAspectModel>();
            Entity = new Document()
            {               
                Customers = new List<DocumentCustomer>(),
                Footer = new DocumentFooter(),
                Rows = new List<DocumentRow>()
            };
        }

        public Document Entity { get; set; }
        public IList<DocumentAspectModel> PaymentMethods { get; set; }
        public IList<DocumentAspectModel> ShippingProviders { get; set; }     
    }
}
