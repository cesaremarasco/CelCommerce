using Nop.Core;

namespace Nop.Plugin.Misc.WarehouseManagement.Domain
{
    public class DocumentAttributeValue : BaseEntity
    {    
        public int DocumentAttribute_Id { get; set; }
        public string Value { get; set; }
        public virtual Document Wm_Document { get; set; }
        public virtual DocumentTypeAttribute Wm_DocumentAttribute { get; set; }
    }
}