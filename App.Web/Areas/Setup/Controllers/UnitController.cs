using Microsoft.AspNetCore.Mvc;

namespace App.Web.Areas.Setup.Controllers
{
    public class UnitController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
