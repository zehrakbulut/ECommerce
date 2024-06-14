using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.directory1 = "Hediyem";
            ViewBag.directory2 = "Ödeme Ekranı";
            ViewBag.directory3 = "Kartla Ödeme";
            return View();
        }
    }
}
