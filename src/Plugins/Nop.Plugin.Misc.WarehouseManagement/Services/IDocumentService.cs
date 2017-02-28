using Nop.Plugin.Misc.WarehouseManagement.Domain;
using System;
using System.Collections.Generic;

namespace Nop.Plugin.Misc.WarehouseManagement.Services
{
    public interface IDocumentService
    {       
        IEnumerable<DocumentSummary> GetAllDocuments(string company = null,
                                                     string documentCode = null,
                                                     int? customerId = null,
                                                     int? documentTypeId = null,
                                                     bool? expiring = null,
                                                     bool? expired = null,
                                                     DateTime? from = null,
                                                     DateTime? to = null,
                                                     string state = null,
                                                     int pageIndex = 0, 
                                                     int pageSize = int.MaxValue);

        IEnumerable<CustomerSummary> GetCustomerByKeyword(string keyWord,
                                                          int pageSize = int.MaxValue);
    }
}
