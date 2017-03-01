using Nop.Core;

namespace Nop.Plugin.Misc.WarehouseManagement.Domain
{
    public class GenericAttribute 
        : BaseEntity
    {
        public int EntityId { get; set; }
        public string KeyGroup { get; set; }
        public string Key { get; set; }        
        public string Value { get; set; }
    }
}
