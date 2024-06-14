using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.ViewComponents.OrderViewComponents
{
    public class _PaymentMethodComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
