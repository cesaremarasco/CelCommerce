using Nop.Plugin.Misc.WarehouseManagement.Domain;

namespace Nop.Plugin.Misc.WarehouseManagement.Models
{
    public class DocumentCoreModel
    {
        public int Id { get; set; }
        public virtual DocumentType DocumentType { get; set; }
    }
}