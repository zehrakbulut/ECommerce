using ECommerce.DtoLayer.CatalogDtos.FeatureDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ECommerce.WebUI.ViewComponents.DefaultViewComponents
{
    public class _FeatureDefaultComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _FeatureDefaultComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

         public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7090/api/Features");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultFeatureDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
  