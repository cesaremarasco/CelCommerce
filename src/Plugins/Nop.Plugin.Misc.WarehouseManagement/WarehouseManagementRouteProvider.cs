﻿using Nop.Web.Framework.Mvc.Routes;
using System.Web.Mvc;
using System.Web.Routing;

namespace Nop.Plugin.Misc.WarehouseManagement
{
    public class WarehouseManagementRouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("Nop.Plugin.Misc.WarehouseManagement.Document",
                            "wm/ndocument/{idDocType}",
                            new
                            {
                                controller = "MiscDocumentManagement",
                                action = "NewDocument",
                                idDocType = UrlParameter.Optional
                            },
                            new[]
                            {
                                "Nop.Plugin.Misc.WarehouseManagement.Controllers"
                            });            

            routes.MapRoute("Nop.Plugin.Misc.WarehouseManagement.DocumentJsonPayLoad",
                           "wm/docpayload/{idDocType}/{documentId}",
                           new
                           {
                               controller = "MiscDocumentManagement",
                               action = "DocumentJsonPayLoad",
                               idDocType = UrlParameter.Optional,
                               documentId = UrlParameter.Optional
                           },
                           new[]
                           {
                                "Nop.Plugin.Misc.WarehouseManagement.Controllers"
                           });

            routes.MapRoute("Nop.Plugin.Misc.WarehouseManagement.Documents", 
                            "wm/documents", 
                            new
                            {
                                controller = "MiscDocumentManagement",
                                action = "Documents"
                            }, 
                            new[]
                            {
                                "Nop.Plugin.Misc.WarehouseManagement.Controllers"
                            });

            routes.MapRoute("Nop.Plugin.Misc.WarehouseManagement.DocTypes", 
                            "wm/doctypes", 
                            new
                            {
                                controller = "MiscDocumentManagement",
                                action = "DocumentTypes"
                            }, 
                            new[] { "Nop.Plugin.Misc.WarehouseManagement.Controllers" });

            routes.MapRoute("Nop.Plugin.Misc.WarehouseManagement.PrintDocument",
                         "wm/printdoc/{documentId}",
                         new
                         {
                             controller = "MiscPrinter",
                             action = "PrintDocument",
                             documentId = UrlParameter.Optional
                         },
                         new[] { "Nop.Plugin.Misc.WarehouseManagement.Controllers" });
        }
        public int Priority
        {
            get { return 0; }
        }
    }
}
