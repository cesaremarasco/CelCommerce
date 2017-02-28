using Nop.Core;
using System;
using System.Collections.Generic;

namespace Nop.Plugin.Misc.WarehouseManagement.Domain
{
    public class Document : BaseEntity
    {        
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
        public virtual ICollection<DocumentCustomer> Customers { get; set; }       
        public virtual ICollection<DocumentRow> Rows { get; set; }
        public virtual ICollection<DocumentTransformation> TrasformedFrom { get; set; }
        public virtual ICollection<DocumentTransformation> TrasformedTo { get; set; }
        public virtual DocumentFooter Footer { get; set; }
        public virtual DocumentType DocumentType { get; set; }
    }
}
