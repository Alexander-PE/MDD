using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace MDD.Default.Pages
{

    [PageAuthorize(typeof(OrdersRow))]
    public class OrdersController : Controller
    {
        [Route("Default/Orders")]
        public ActionResult Index()
        {
            return View("~/Modules/Default/Orders/OrdersIndex.cshtml");
        }
    }
}