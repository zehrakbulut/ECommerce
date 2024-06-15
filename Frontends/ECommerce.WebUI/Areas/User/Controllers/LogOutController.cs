using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Areas.User.Controllers
{
    public class LogOutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
