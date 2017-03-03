using Nop.Services.Localization;
using System.Web.Routing;
using Nop.Core.Plugins;
using Nop.Web.Framework.Menu;

namespace Nop.Plugin.Misc.WarehouseManagement
{
    public class WarehouseManagementPlugIn : BasePlugin, IAdminMenuPlugin
    {
        public WarehouseManagementPlugIn()
        {
            Install();
        }    

        public void GetConfigurationRoute(out string actionName, out string controllerName, out RouteValueDictionary routeValues)
        {
            actionName = "Configure";
            controllerName = "MiscWarehouseManagement";
            routeValues = new RouteValueDictionary()
            {
                { "Namespaces", "Nop.Plugin.Misc.WarehouseManagement.Controllers" },
                { "area", null }
            };
        }

        public void ManageSiteMap(SiteMapNode rootNode)
        {   
            var areaItem = new SiteMapNode()
            {
                SystemName = "Warehouse Management",
                Title = "Warehouse Management",
                IconClass = "fa-book",        
                Visible = true,
                RouteValues = new RouteValueDictionary() { { "area", null } },
            };

            var documentsItem = new SiteMapNode()
            {
                SystemName = "Documents",
                Title = "Documents",
                IconClass = "fa-book",
                Url = "wm/documents",
                Visible = true,
                RouteValues = new RouteValueDictionary() { { "area", null } },
            };

            var documentTypesItem = new SiteMapNode()
            {
                SystemName = "Document Types",
                Title = "Document Types",
                IconClass = "fa-book",
                Url = "wm/doTypes",
                Visible = true,
                RouteValues = new RouteValueDictionary() { { "area", null } },
            };

            areaItem.ChildNodes.Add(documentsItem);
            areaItem.ChildNodes.Add(documentTypesItem);

            rootNode.ChildNodes.Add(areaItem);
        }

        public override void Install()
        {
            this.AddOrUpdatePluginLocaleResource("Plugin.Misc.WarehouseManagement.Document.Head", "Head");
            this.AddOrUpdatePluginLocaleResource("Plugin.Misc.WarehouseManagement.Document.Body", "Body");
            this.AddOrUpdatePluginLocaleResource("Plugin.Misc.WarehouseManagement.Document.Customers", "Customers");

            //base.Install();
        }
    }
}
