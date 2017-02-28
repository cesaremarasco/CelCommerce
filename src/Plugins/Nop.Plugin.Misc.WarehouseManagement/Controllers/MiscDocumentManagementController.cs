using Nop.Plugin.Misc.WarehouseManagement.Services;
using System.Web.Mvc;
using Nop.Plugin.Misc.WarehouseManagement.Models;
using System.Collections.Generic;
using System.Linq;

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
            return View(RequestedViewPath,new DocumentModel());
        }

        public ActionResult DocumentTypes()
        {
            return View(RequestedViewPath);
        }

        public ActionResult CustomerSearchAutoComplete(string term)
        {
            const int searchTermMinimumLength = 3;
            if (string.IsNullOrWhiteSpace(term) || term.Length < searchTermMinimumLength)
                return Content("");
           
            const int productNumber = 15;

            var customers = _documentService.GetCustomerByKeyword(term, productNumber);

            var result = (from p in customers
                          select new
                          {
                              label = p.Company,
                              customerid = p.Id
                          })
                           .ToList();
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
