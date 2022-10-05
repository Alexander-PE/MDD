using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace MDD.Default.Pages
{

    [PageAuthorize(typeof(CustomersRow))]
    public class CustomersController : Controller
    {
        [Route("Default/Customers")]
        public ActionResult Index()
        {
            return View("~/Modules/Default/Customers/CustomersIndex.cshtml");
        }
    }
}