using Nop.Web.Framework.Mvc;
using System;
using System.Collections.Generic;

namespace Nop.Plugin.Misc.WarehouseManagement.Models
{
    public class DocumentModel : BaseNopEntityModel
    {
        public DocumentModel()
        {
            Customers = new List<DocumentCustomerModel>();
            Rows = new List<DocumentRowModel>();
            DocumentAttributeValues = new List<DocumentAttributeValueModel>();
        }

        public int? DocumentType_Id { get; set; }
        public int? Year { get; set; }
        public string DocumentNumber { get; set; }        
        public DateTime? RegistrationDate { get; set; }      
        public DateTime? DocumentDate { get; set; }       
        public DateTime? EndDateValidity { get; set; }        
        public DateTime? LastUpdateDate { get; set; }        
        public DateTime? LastEmailDate { get; set; }
        public bool? Trasformed { get; set; }
        public string State { get; set; }
        public string Notes { get; set; }
        public virtual ICollection<DocumentCustomerModel> Customers { get; set; }
        public virtual ICollection<DocumentRowModel> Rows { get; set; }      
        public virtual ICollection<DocumentAttributeValueModel> DocumentAttributeValues { get; set; }      

    }
}
