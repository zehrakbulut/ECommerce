using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Areas.User.ViewComponents.UserLayoutViewComponents
{
    public class _UserLayoutHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
