using Microsoft.AspNetCore.Mvc;
using User.Api.Dto;
using User.Domain.Entities.Services;

namespace User.Api.Controllers
{
    [ApiController]
    [Route("address")]

    public class AddressController : Controller
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetAddress([FromRoute] int id)
        {
            var address = _addressService.GetAddressById(id);
            return Ok(address);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAddress([FromBody] AddressDto dto)
        {
            var address = _addressService.CreteAddress(dto.Name, dto.State, dto.City, dto.UF, dto.District, dto.Number,
                dto.Complement);

            return Ok(address);
        }

        [HttpPost]
        [Route("{id}")]
        public async Task<IActionResult> EditAddress([FromRoute] int id, [FromBody] AddressDto dto)
        {
            var address = await _addressService.GetAddressById(id);

            if (address is not null)
            {
                await _addressService.Update(dto.Id, dto.Name, dto.State, dto.City, dto.UF, dto.District, dto.Number,
                    dto.Complement);
            }

            return Ok(address);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteUser([FromRoute] int id)
        {
            var address = await _addressService.GetAddressById(id);

            if (address != null)
            {
                await _addressService.Delete(id);
            }

            return Ok(address);
        }
    }
}
