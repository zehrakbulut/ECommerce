﻿using ECommerce.DtoLayer.CatalogDtos.CategoryDtos;
using ECommerce.DtoLayer.CatalogDtos.ProductDtos;
using ECommerce.WebUI.Services.CatalogServices.CategoryServices;
using ECommerce.WebUI.Services.CatalogServices.ProductServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Product")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        void ProductViewBagList()
        {
            ViewBag.v1 = "Ana Sayfa";
            ViewBag.v2 = "Ürünler";
            ViewBag.v3 = "Ürün Listesi";
            ViewBag.v0 = "Ürün İşlemleri";
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            ProductViewBagList();
            var values = await _productService.GetAllProductAsync();
            return View(values);  
        }

        [Route("ProductListWithCategory")]
        public async Task<IActionResult> ProductListWithCategory()
        {
            ProductViewBagList();

            //var client = _httpClientFactory.CreateClient();
            //var responseMessage = await client.GetAsync("https://localhost:7090/api/Products/ProductListWithCategory");
            //if (responseMessage.IsSuccessStatusCode)
            //{
            //    var jsonData = await responseMessage.Content.ReadAsStringAsync();
            //    var values = JsonConvert.DeserializeObject<List<ResultProductWithCategoryDto>>(jsonData);
            //    return View(values);
            //}
            return View();
        }

        [Route("CreateProduct")]
        [HttpGet]
        public async Task<IActionResult> CreateProduct()
        {
            ProductViewBagList();
            var values = await _categoryService.GetAllCategoryAsync();
            List<SelectListItem> categoryValues = (from x in values
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId
                                                   }).ToList();
            ViewBag.CategoryValues = categoryValues;
            return View();
        }

        [HttpPost]
        [Route("CreateProduct")]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            await _productService.CreateProductAsync(createProductDto);
            return RedirectToAction("Index", "Product", new { area = "Admin" });
        }

        [Route("DeleteProduct/{id}")]
        public async Task<IActionResult> DeleteProduct(string id)
        {
            await _productService.DeleteProductAsync(id);
            return RedirectToAction("Index", "Product", new { area = "Admin" });
        }

        [Route("UpdateProduct/{id}")]
        [HttpGet]
        public async Task<IActionResult> UpdateProduct(string id)
        {
            ProductViewBagList();


            var values = await _categoryService.GetAllCategoryAsync();
            List<SelectListItem> categoryValues = (from x in values
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId
                                                   }).ToList();
            ViewBag.CategoryValues = categoryValues;

            var productValues = await _productService.GetByIdProductAsync(id);
            return View(productValues);
        }

        [Route("UpdateProduct/{id}")]
        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            await _productService.UpdateProductAsync(updateProductDto);
            return RedirectToAction("Index", "Product", new { area = "Admin" });
        }
    }
}
