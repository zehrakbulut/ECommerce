using ECommerce.Catalog.Dtos.ContactDtos;
using ECommerce.Catalog.Services.ContactServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Catalog.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _ContactService;

        public ContactsController(IContactService ContactService)
        {
            _ContactService = ContactService;
        }

        [HttpGet]
        public async Task<IActionResult> ContactList()
        {
            var values = await _ContactService.GetAllContactAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetContactById(string id)
        {
            var values = await _ContactService.GetByIdContactAsync(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactDto createContactDto)
        {
            await _ContactService.CreateContactAsync(createContactDto);
            return Ok("İletişim Bilgisi başarıyla eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteContact(string id)
        {
            await _ContactService.DeleteContactAsync(id);
            return Ok("İletişim Bilgisi başarıyla silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateContact(UpdateContactDto updateContactDto)
        {
            await _ContactService.UpdateContactAsync(updateContactDto);
            return Ok("İletişim Bilgisi başarıyla güncellendi");
        }
    }
}
