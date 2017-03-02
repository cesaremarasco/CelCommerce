using System.IO;

namespace Nop.Plugin.Misc.WarehouseManagement.Services
{
    public interface IPrintService
    {
        void PrintTestDoc(Stream stream);
    }
}
