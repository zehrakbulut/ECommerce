using ECommerce.DtoLayer.CatalogDtos.ProductDtos;
using ECommerce.DtoLayer.CatalogDtos.ProductImageDtos;
using ECommerce.WebUI.Services.CatalogServices.ProductImageServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ECommerce.WebUI.ViewComponents.ProductDetailViewComponents
{
    public class _ProductDetailImageSliderComponentPartial:ViewComponent
    {
        private readonly IProductImageService _productImageService;

        public _ProductDetailImageSliderComponentPartial(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var values=await _productImageService.GetByProductIdProductImageAsync(id);
            return View(values);
        }
    }
}
