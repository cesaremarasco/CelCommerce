using Nop.Core;
using System.Collections.Generic;

namespace Nop.Plugin.Misc.WarehouseManagement.Domain
{
    public class DocumentType : BaseEntity
    {
        public int InOutType_Id { get; set; }
        public int CustomerRole_Id { get; set; }      
        public string Code { get; set; }
        public string Description { get; set; }
        public bool Extended { get; set; }
        public bool HasAmount { get; set; }
        public bool HasBody { get; set; }
        public bool CanBeSentByMail { get; set; }
        public bool OnlyFromTransformation { get; set; }
        public bool CloseParentDoc { get; set; }
        public bool MultipleHead { get; set; }
        public int? TransformationIndex { get; set; }         
        public virtual ICollection<Document> Document { get; set; }
        public virtual InOutType InOutType { get; set; }       
        public virtual ICollection<DocumentType> TrasformationChildDocuments { get; set; }      
        public virtual ICollection<DocumentType> TrasformationParentDocuments { get; set; }
        public virtual ICollection<DocumentTypeAttribute> DocumentAttributes { get; set; }

    }
}
