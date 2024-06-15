using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Areas.User.ViewComponents.UserLayoutViewComponents
{
    public class _UserLayoutSideBarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
