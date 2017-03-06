using Nop.Core;
using System.Collections.Generic;

namespace Nop.Plugin.Misc.WarehouseManagement.Domain
{
    public class DocumentTypeAttribute : BaseEntity
    {   
        public int DocumentType_Id { get; set; }       
        public string Name { get; set; }
        public string TextPrompt { get; set; }
        public bool IsRequired { get; set; }
        public int AttributeControlTypeId { get; set; }
        public int DisplayOrder { get; set; }
        public int? ValidationMinLength { get; set; }
        public int? ValidationMaxLength { get; set; }
        public string ValidationFileAllowedExtensions { get; set; }
        public int? ValidationFileMaximumSize { get; set; }
        public string DefaultValue { get; set; }
        public string ConditionAttributeXml { get; set; }
        public virtual ICollection<DocumentAttributeValue> DocumentAttributeValues { get; set; }
        public virtual DocumentType DocumentType { get; set; }
    }
}