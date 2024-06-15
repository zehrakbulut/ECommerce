using ECommerce.DtoLayer.OrderDtos.OrderOrderingDtos;

namespace ECommerce.WebUI.Services.OrderServices.OrderOrderingServices
{
    public interface IOrderOrderingService
    {
        Task<List<ResultOrderingByUserIdDto>> GetOrderingByUserId(string id);
    }
}
