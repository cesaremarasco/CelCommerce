using System.Web.Mvc;

namespace Nop.Plugin.Misc.WarehouseManagement.Controllers
{
    public class MiscWarehouseManagementController : Controller
    {
        public MiscWarehouseManagementController()
        {

        }

        public ActionResult Configure()
        {
            return View();
        }
    }
}
