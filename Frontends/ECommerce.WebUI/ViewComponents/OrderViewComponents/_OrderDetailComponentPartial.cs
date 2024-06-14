using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.ViewComponents.OrderViewComponents
{
    public class _OrderDetailComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
