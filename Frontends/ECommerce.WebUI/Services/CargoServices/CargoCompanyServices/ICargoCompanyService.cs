using ECommerce.DtoLayer.CargoDtos.CargoCompanyDtos;

namespace ECommerce.WebUI.Services.CargoServices.CargoCompanyServices
{
    public interface ICargoCompanyService
    {
        Task<List<ResultCargoCompanyDto>> GetAllCargoCompanyAsync();
        Task CreateCargoCompanyAsync(CreateCargoCompanyDto createCargoCompanyDto);
        Task UpdateCargoCompanyAsync(UpdateCargoCompanyDto updateCargoCompanyDto);
        Task DeleteCargoCompanyAsync(string id);
        Task<UpdateCargoCompanyDto> GetByIdCargoCompanyAsync(string id);
    }
}
