using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Nop.Plugin.Misc.WarehouseManagement.Models
{
    public class DocumentModel
    {
        public DocumentModel()
        {
            AvailableDocumentTypes = new List<SelectListItem>();
        }

        public int? CustomerId { get; set; }

        [UIHint("DateNullable")]
        public DateTime? StartDate { get; set; }

        [UIHint("DateNullable")]
        public DateTime? EndDate { get; set; }

        public string NumDoc { get; set; }

        public int DocumentTypeId { get; set; }

        public IList<SelectListItem> AvailableDocumentTypes { get; set; }
    }
}
