using Microsoft.AspNetCore.Mvc;

namespace App.Web.Areas.Setup.Controllers
{
    [Area("Setup")]
    public class BrandController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
