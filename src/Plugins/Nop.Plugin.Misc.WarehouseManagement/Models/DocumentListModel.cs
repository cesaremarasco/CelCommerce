using Nop.Plugin.Misc.WarehouseManagement.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Nop.Plugin.Misc.WarehouseManagement.Models
{
    public class DocumentListModel
    {
        private List<SelectListItem> _availableDocumentTypesListItems;

        public DocumentListModel()
        {
            AvailableDocumentTypes = new List<DocumentTypeSummary>(); 
        }

        public int? CustomerId { get; set; }

        [UIHint("DateNullable")]
        public DateTime? StartDate { get; set; }

        [UIHint("DateNullable")]
        public DateTime? EndDate { get; set; }

        public string NumDoc { get; set; }

        public int? DocumentTypeId { get; set; }

        public string Company { get; set; }

        public string LocalizedresourceAll { get; set; }

        public IList<SelectListItem> AvailableDocumentTypesListItems
        {
            get
            {
                _availableDocumentTypesListItems = new List<SelectListItem>();

                _availableDocumentTypesListItems.Add(new SelectListItem { Text = LocalizedresourceAll, Value = "0" });

                foreach (var w in AvailableDocumentTypes)
                    _availableDocumentTypesListItems.Add(new SelectListItem { Text = string.Format("{0} - {1}", w.Role, w.Description), Value = w.Id.ToString() });

                return _availableDocumentTypesListItems;
            }
        }
        
        public IList<DocumentTypeSummary> AvailableDocumentTypes { get; set; }
    }
}
