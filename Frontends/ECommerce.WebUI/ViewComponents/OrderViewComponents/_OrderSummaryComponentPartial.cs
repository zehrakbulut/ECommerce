using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.ViewComponents.OrderViewComponents
{
    public class _OrderSummaryComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
