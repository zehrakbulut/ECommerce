using ECommerce.DtoLayer.CatalogDtos.ProductDtos;
using ECommerce.WebUI.Services.CatalogServices.ProductServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ECommerce.WebUI.ViewComponents.ProductDetailViewComponents
{
    public class _ProductDetailFeatureComponentPartial:ViewComponent
    {
        private readonly IProductService _productService;

        public _ProductDetailFeatureComponentPartial(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var values=await _productService.GetByIdProductAsync(id);
            return View(values);
        }
    }
}
