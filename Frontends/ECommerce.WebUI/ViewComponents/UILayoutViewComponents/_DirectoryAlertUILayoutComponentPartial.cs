using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _DirectoryAlertUILayoutComponentPartial:ViewComponent 
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
