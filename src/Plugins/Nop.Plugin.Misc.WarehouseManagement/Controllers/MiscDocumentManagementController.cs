using Nop.Plugin.Misc.WarehouseManagement.Services;
using System.Web.Mvc;
using Nop.Plugin.Misc.WarehouseManagement.Models;
using System.Linq;
using Nop.Services.Localization;
using Nop.Web.Framework.Kendoui;
using Nop.Core.Caching;
using Nop.Services.Payments;

namespace Nop.Plugin.Misc.WarehouseManagement.Controllers
{
    public class MiscDocumentManagementController : BaseController
    {
        private IDocumentService _documentService;
        private ILocalizationService _localizationService;
        private IPaymentService _paymentService;

        public MiscDocumentManagementController(IDocumentService documentService,
                                                ILocalizationService localizationService,
                                                IPaymentService paymentService)
        {
            _documentService = documentService;
            _localizationService = localizationService;
            _paymentService = paymentService;     
        }
               
        public ActionResult Documents()
        {
            var model = new DocumentListModel()
            {
                LocalizedresourceAll = _localizationService.GetResource("Admin.Common.All"),
                AvailableDocumentTypes = _documentService.GetAllDocumentTypes.ToList()
            };          

            return View(RequestedViewPath, model);
        }

        public ActionResult DocumentTypes()
        {
            return View(RequestedViewPath);
        }

        public ActionResult EditDocument(int documentId)
        {            
            ViewBag.DocumentId = documentId;
            return View(LoadByViewName("Document"));
        }

        public ActionResult NewDocument(int idDocType)
        {
            var model = new DocumentCoreModel()
            {
                DocumentType = _documentService.GetDocumentTypeById(idDocType)
            };

            return View(LoadByViewName("Document"), model);
        }

        [HttpGet]
        public ActionResult DocumentJsonPayLoad(int idDocType, int documentId)
        {
            if (idDocType == 0 && documentId == 0)
                throw new System.Exception("Invalid call");

            var docModel = new DocumentModel();

            docModel.PaymentMethods = _paymentService.LoadAllPaymentMethods()
                                                     .Select(x => new DocumentAspectModel()
                                                     {
                                                         SystemName = x.PluginDescriptor.SystemName,
                                                         Description = x.PluginDescriptor.FriendlyName
                                                     })
                                                     .ToList();

            if (documentId != 0)
                docModel.Entity.DocumentType = _documentService.GetDocumentTypeById(idDocType);  

            return new JsonResult()
            {
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                Data = docModel
            };
        }

        [HttpPost]
        public ActionResult CreateDocument(DocumentModel currentDocument)
        {
            var currentResult = new JsonResult();
            currentResult.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            currentResult.Data = "Saved !";
            return currentResult;
        }

        [HttpPost]
        public ActionResult DocumentList(DataSourceRequest command, DocumentListModel model)
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
