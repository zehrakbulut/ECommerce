﻿using ECommerce.DtoLayer.CatalogDtos.ProductDetailDtos;
using ECommerce.WebUI.Services.CatalogServices.ProductDetailServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ECommerce.WebUI.ViewComponents.ProductDetailViewComponents
{
    public class _ProductDetailDescriptionComponentPartial:ViewComponent
    {
        private readonly IProductDetailService _productDetailService;

        public _ProductDetailDescriptionComponentPartial(IProductDetailService productDetailService)
        {
            _productDetailService = productDetailService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var values=await _productDetailService.GetByProductIdProductDetailAsync(id);
            return View(values);
        }
    }
}
