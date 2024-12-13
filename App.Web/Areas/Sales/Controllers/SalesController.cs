using Microsoft.AspNetCore.Mvc;

namespace App.Web.Areas.Sales.Controllers
{
    [Area("Sales")]
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
