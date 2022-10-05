using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace MDD.Default.Pages
{

    [PageAuthorize(typeof(ProductosRow))]
    public class ProductosController : Controller
    {
        [Route("Default/Productos")]
        public ActionResult Index()
        {
            return View("~/Modules/Default/Productos/ProductosIndex.cshtml");
        }
    }
}