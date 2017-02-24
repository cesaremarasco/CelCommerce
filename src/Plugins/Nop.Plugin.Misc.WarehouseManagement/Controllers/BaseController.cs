using System.Web.Mvc;

namespace Nop.Plugin.Misc.WarehouseManagement.Controllers
{
    public abstract class BaseController : Controller
    {
        protected string RequestedViewPath
        {
            get
            {
                string controllerName = ControllerContext.RouteData.Values["controller"].ToString();
                string actionName = this.ControllerContext.RouteData.Values["action"].ToString();

                return string.Format("~/Plugins/Misc.WarehouseManagement/Views/{0}/{1}.cshtml", controllerName, actionName);
            }
        }
    }
}
