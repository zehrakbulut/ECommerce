﻿using ECommerce.Catalog.Dtos.OfferDiscountDtos;
using ECommerce.Catalog.Services.OfferDiscountServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Catalog.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class OfferDiscountsController : ControllerBase
    {
        private readonly IOfferDiscountService _offerDiscountService;

        public OfferDiscountsController(IOfferDiscountService OfferDiscountService)
        {
            _offerDiscountService = OfferDiscountService;
        }

        [HttpGet]
        public async Task<IActionResult> OfferDiscountList()
        {
            var values = await _offerDiscountService.GetAllOfferDiscountAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOfferDiscountById(string id)
        {
            var values = await _offerDiscountService.GetByIdOfferDiscountAsync(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOfferDiscount(CreateOfferDiscountDto createOfferDiscountDto)
        {
            await _offerDiscountService.CreateOfferDiscountAsync(createOfferDiscountDto);
            return Ok("Özel Teklif başarıyla eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteOfferDiscount(string id)
        {
            await _offerDiscountService.DeleteOfferDiscountAsync(id);
            return Ok("Özel Teklif başarıyla silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOfferDiscount(UpdateOfferDiscountDto updateOfferDiscountDto)
        {
            await _offerDiscountService.UpdateOfferDiscountAsync(updateOfferDiscountDto);
            return Ok("Özel Teklif başarıyla güncellendi");
        }
    }
}
