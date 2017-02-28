using Nop.Core;
using System;

namespace Nop.Plugin.Misc.WarehouseManagement.Domain
{
    public class DocumentTransformation : BaseEntity
    {             
        public int ChildDocument_Id { get; set; }      
        public int Customer_Id { get; set; }
        public DateTime TransformationDate { get; set; }
        public virtual Document FromDocument { get; set; }
        public virtual Document ToDocument { get; set; }
    }
}
