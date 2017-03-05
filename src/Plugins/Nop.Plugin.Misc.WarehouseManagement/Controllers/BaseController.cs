using System.Web.Mvc;

namespace Nop.Plugin.Misc.WarehouseManagement.Controllers
{
    public abstract class BaseController 
        : Controller
    {
        protected string RequestedViewPath
        {
            get
            {
                string controllerName = ControllerContext.RouteData.Values["controller"].ToString();
                string actionName = ControllerContext.RouteData.Values["action"].ToString();

                return string.Format("~/Plugins/Misc.WarehouseManagement/Views/{0}/{1}.cshtml", controllerName, actionName);
            }
        }

        protected string SharedViewPath(string sharedViewName)
        {
            return string.Format("~/Plugins/Misc.WarehouseManagement/Views/Shared/{0}.cshtml", sharedViewName);
        }

        protected string LoadByViewName(string viewName)
        {
            string controllerName = ControllerContext.RouteData.Values["controller"].ToString();
            return string.Format("~/Plugins/Misc.WarehouseManagement/Views/{0}/{1}.cshtml", controllerName, viewName);
        }
    }
}
