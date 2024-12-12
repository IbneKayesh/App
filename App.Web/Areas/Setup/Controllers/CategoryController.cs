using Microsoft.AspNetCore.Mvc;

namespace App.Web.Areas.Setup.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
