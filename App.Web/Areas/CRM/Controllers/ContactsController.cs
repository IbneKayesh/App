using Microsoft.AspNetCore.Mvc;

namespace App.Web.Areas.CRM.Controllers
{
    [Area("CRM")]
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
