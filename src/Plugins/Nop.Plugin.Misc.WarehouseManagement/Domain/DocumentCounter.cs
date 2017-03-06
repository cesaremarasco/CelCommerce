using Nop.Core;

namespace Nop.Plugin.Misc.WarehouseManagement.Domain
{
    public class DocumentCounter : BaseEntity
    {
        public int Document_Id { get; set; }

        public int DocumentType_Id { get; set; }

        public int Year { get; set; }

        public int CurrentDocNumber { get; set; }
    }
}