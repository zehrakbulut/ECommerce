using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
