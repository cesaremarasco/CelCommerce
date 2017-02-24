using System.Collections.Generic;
using Nop.Plugin.Misc.WarehouseManagement.Domain;
using Nop.Core.Data;
using System.Linq;
using System;

namespace Nop.Plugin.Misc.WarehouseManagement.Services
{
    public class DocumentService : IDocumentService
    {
        private readonly IRepository<Document> _documentRepository;

        public DocumentService(IRepository<Document> documentRepository)
        {
            _documentRepository = documentRepository;
        }

        public IEnumerable<Document> AllDocuments
        {
            get
            {
                return _documentRepository.Table;
            }           
        }

        public IEnumerable<Document> GetDocumentsByCustomerId(int customerId)
        {
            return null;
        }       

        public IEnumerable<Document> GetDocumentsByDocumentTypes(List<int> documentTypes)
        {
            return _documentRepository.Table.Where(x => documentTypes.Contains(x.DocumentType_Id.Value));
        }
    }
}
