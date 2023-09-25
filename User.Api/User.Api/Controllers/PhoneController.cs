using Microsoft.AspNetCore.Mvc;
using User.Api.Dto;
using User.Domain.Entities.Services;

namespace User.Api.Controllers
{
    [ApiController]
    [Route("phone")]

    public class PhoneController : Controller
    {
        private readonly IPhoneService _phoneService;

        public PhoneController(IPhoneService phoneService)
        {
            _phoneService = phoneService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetPhoneById([FromRoute] int id)
        {
            var phone = _phoneService.GetPhoneById(id);
            return Ok(phone);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePhone([FromBody] PhoneDto dto)
        {
            var phone = _phoneService.Save(dto.DDD, dto.Number);
            return Ok(phone);
        }

        [HttpPost]
        [Route("{id}")]
        public async Task<IActionResult> EditPhone([FromRoute] int id, [FromBody] PhoneDto dto)
        {
            var phone = _phoneService.GetPhoneById(id);

            if (phone is not null)
            {
                await _phoneService.Update(dto.Id, dto.DDD, dto.Number);
            }

            return Ok(phone);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeletePhone([FromRoute] int id)
        {
            var phone = await _phoneService.GetPhoneById(id);

            if (phone != null)
            {
                await _phoneService.Delete(id);
            }

            return Ok(phone);
        }
    }
}
