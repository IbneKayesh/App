using Microsoft.AspNetCore.Mvc;

namespace App.Web.Areas.Setup.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
