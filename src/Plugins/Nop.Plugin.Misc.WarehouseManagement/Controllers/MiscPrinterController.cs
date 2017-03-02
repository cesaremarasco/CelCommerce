using Nop.Core;
using Nop.Plugin.Misc.WarehouseManagement.Services;
using System.IO;
using System.Web.Mvc;

namespace Nop.Plugin.Misc.WarehouseManagement.Controllers
{
    public class MiscPrinterController : BaseController
    {
        private readonly IPrintService _printService;

        public MiscPrinterController(IPrintService printService)
        {
            _printService = printService;
        }       

        public ActionResult PrintDocument(int? documentId)
        {
            if (documentId == null)
                throw new System.ArgumentException(string.Format("Invalid document id"));           

            ViewBag.DocumentId = documentId;
            return View(SharedViewPath("PdfViewer"));
        }

        public ActionResult PdfDocumentViewer(int documentId)
        {          
            byte[] bytes;

            using (var stream = new MemoryStream())
            {
                _printService.PrintTestDoc(stream);
                bytes = stream.ToArray();
            }

            return File(bytes, MimeTypes.ApplicationPdf,string.Format("Document{0}.pdf",documentId));
        }
    }
}
