using ECommerce.DtoLayer.IdentityDtos.UserDtos;

namespace ECommerce.WebUI.Services.UserIdentityServices
{
    public interface IUserIdentityService
    {
        Task<List<ResultUserDto>> GetAllUserListAsync();
    }
}
