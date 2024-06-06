using ECommerce.DtoLayer.CatalogDtos.CategoryDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ECommerce.WebUI.ViewComponents.DefaultViewComponents
{
    public class _CategoriesDefaultComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _CategoriesDefaultComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7090/api/Categories");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
