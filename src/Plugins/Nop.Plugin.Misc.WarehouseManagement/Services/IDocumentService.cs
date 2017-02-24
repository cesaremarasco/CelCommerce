using Nop.Plugin.Misc.WarehouseManagement.Domain;
using System.Collections.Generic;

namespace Nop.Plugin.Misc.WarehouseManagement.Services
{
    public interface IDocumentService
    {
        IEnumerable<Document> GetDocumentsByCustomerId(int customerId);

        IEnumerable<Document> GetDocumentsByDocumentTypes(List<int> documentTypes);

        IEnumerable<Document> AllDocuments { get; }
    }
}
