using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.directory1 = "Hediyem";
            ViewBag.directory2 = "Ana Sayfa";
            ViewBag.directory3 = "Ürün Listesi";
            return View();
        }
    }
}
