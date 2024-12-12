using Microsoft.AspNetCore.Mvc;

namespace App.Web.Areas.Sales.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
