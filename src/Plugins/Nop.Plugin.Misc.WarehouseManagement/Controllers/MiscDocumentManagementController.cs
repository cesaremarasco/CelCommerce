using Nop.Plugin.Misc.WarehouseManagement.Services;
using System.Web.Mvc;

namespace Nop.Plugin.Misc.WarehouseManagement.Controllers
{
    public class MiscDocumentManagementController : BaseController
    {
        private IDocumentService _documentService;

        public MiscDocumentManagementController(IDocumentService documentService)
        {
            _documentService = documentService;
        }
               
        public ActionResult Documents()
        {
            return View(RequestedViewPath, _documentService.AllDocuments);
        }
    }
}
