﻿using Nop.Plugin.Misc.WarehouseManagement.Services;
using System.Web.Mvc;
using Nop.Plugin.Misc.WarehouseManagement.Models;
using System.Linq;
using Nop.Services.Localization;
using Nop.Web.Framework.Kendoui;
using Nop.Core.Caching;

namespace Nop.Plugin.Misc.WarehouseManagement.Controllers
{
    public class MiscDocumentManagementController : BaseController
    {
        private IDocumentService _documentService;
        private ILocalizationService _localizationService;
        private ICacheManager _icacheManager;       

        public MiscDocumentManagementController(IDocumentService documentService,
                                                ILocalizationService localizationService)
        {
            _documentService = documentService;
            _localizationService = localizationService;            
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

        public ActionResult CreateDocument(int idDocType)
        {
            var docModel = new DocumentModel(); 

            docModel.Entity.DocumentType = _documentService.GetDocumentTypeById(idDocType);         

            return View(LoadByViewName("Document"), docModel);
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
