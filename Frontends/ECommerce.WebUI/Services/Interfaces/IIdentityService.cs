using ECommerce.DtoLayer.IdentityDtos.LoginDtos;

namespace ECommerce.WebUI.Services.Interfaces
{
    public interface IIdentityService
    {
        Task<bool> SignIn(SignInDto signIpDto);
        Task<bool> GetRefreshToken();
    }
}
