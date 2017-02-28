using Nop.Core;
using System.Collections.Generic;

namespace Nop.Plugin.Misc.WarehouseManagement.Domain
{
    public class InOutType 
        : BaseEntity
    {                
        public string Description { get; set; }        
        public virtual ICollection<DocumentType> DocumentTypes { get; set; }
    }
}
