using Microsoft.AspNetCore.Mvc;

namespace App.Web.Areas.Setup.Controllers
{
    public class BrandController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
