using Nop.Plugin.Misc.WarehouseManagement.Services;
using System.Web.Mvc;
using Nop.Plugin.Misc.WarehouseManagement.Models;
using System.Linq;
using Nop.Services.Localization;
using Nop.Web.Framework.Kendoui;

namespace Nop.Plugin.Misc.WarehouseManagement.Controllers
{
    public class MiscDocumentManagementController : BaseController
    {
        private IDocumentService _documentService;
        private ILocalizationService _localizationService;

        public MiscDocumentManagementController(IDocumentService documentService,
                                                ILocalizationService localizationService)
        {
            _documentService = documentService;
            _localizationService = localizationService;
        }
               
        public ActionResult Documents()
        {
            var model = new DocumentModel();
            
            model.AvailableDocumentTypes.Add(new SelectListItem { Text = _localizationService.GetResource("Admin.Common.All"), Value = "0" });
            foreach (var w in _documentService.GetAllDocumentTypes)
                model.AvailableDocumentTypes.Add(new SelectListItem { Text = string.Format("{0} - {1}",w.Role,w.Description), Value = w.Id.ToString() });

            return View(RequestedViewPath, model);
        }

        public ActionResult DocumentTypes()
        {
            return View(RequestedViewPath);
        }

        [HttpPost]
        public ActionResult DocumentList(DataSourceRequest command, DocumentModel model)
        {
            var result = _documentService.GetAllDocuments(model.Company,
                                                          model.NumDoc,
                                                          model.CustomerId,
                                                          model.DocumentTypeId,
                                                          null,
                                                          null,
                                                          model.StartDate,
                                                          model.EndDate,
                                                          pageIndex: command.Page - 1,
                                                          pageSize: command.PageSize);

            var gridModel = new DataSourceResult
            {
                Data = result
            };

            return new JsonResult
            {
                Data = gridModel
            };
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
