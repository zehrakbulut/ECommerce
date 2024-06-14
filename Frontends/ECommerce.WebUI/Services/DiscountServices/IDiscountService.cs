using ECommerce.DtoLayer.DiscountDtos;

namespace ECommerce.WebUI.Services.DiscountServices
{
    public interface IDiscountService
    {
        Task<GetDiscountCodeDetailByCode> GetDiscountCode(string code);
    }
}
