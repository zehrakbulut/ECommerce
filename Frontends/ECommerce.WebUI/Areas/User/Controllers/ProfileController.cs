using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Areas.User.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
