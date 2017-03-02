using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;

namespace Nop.Plugin.Misc.WarehouseManagement.Services
{
    public class PrintService : IPrintService
    {
        public void PrintTestDoc(Stream stream)
        {
            if (stream == null)
                throw new ArgumentNullException("stream");  


            var doc = new Document(PageSize.LETTER);
            var pdfWriter = PdfWriter.GetInstance(doc, stream);
            doc.Open();

            doc.Add(new Paragraph("Hello World"));

            doc.Close();
        }
    }
}
