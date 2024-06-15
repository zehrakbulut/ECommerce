using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Areas.User.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
