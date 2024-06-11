using ECommerce.WebUI.Models;

namespace ECommerce.WebUI.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserDetailViewModel> GetUserInfo();
    }
}
