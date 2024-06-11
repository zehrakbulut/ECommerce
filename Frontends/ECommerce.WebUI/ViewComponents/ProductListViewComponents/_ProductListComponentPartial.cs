using ECommerce.DtoLayer.CatalogDtos.ProductDtos;
using ECommerce.WebUI.Services.CatalogServices.ProductServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ECommerce.WebUI.ViewComponents.ProductListViewComponents
{
    public class _ProductListComponentPartial : ViewComponent
    {
        private readonly IProductService _productService;

        public _ProductListComponentPartial(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var values = await _productService.GetProductsWithCategoryByCategoryIdAsync(id);
            return View(values);
        }
    }
}
