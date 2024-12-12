using Microsoft.AspNetCore.Mvc;

namespace App.Web.Areas.Setup.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
