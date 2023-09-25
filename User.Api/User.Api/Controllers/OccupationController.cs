using Microsoft.AspNetCore.Mvc;
using User.Api.Dto;
using User.Domain.Entities.Services;

namespace User.Api.Controllers
{
    [ApiController]
    [Route("occupation")]

    public class OccupationController : Controller
    {
        private readonly IOccupationService _occupationService;

        public OccupationController(IOccupationService service)
        {
            _occupationService = service;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetOccupationById([FromRoute] int id)
        {
            var occupation = _occupationService.GetOccupationById(id);
            return Ok(occupation);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAddress([FromBody] OccupationDto dto)
        {
            var occupation = _occupationService.Save(dto.NameOccupation);
            return Ok(occupation);
        }

        [HttpPost]
        [Route("{id}")]
        public async Task<IActionResult> EditOccupaption([FromRoute] int id, [FromBody] OccupationDto dto)
        {
            var occupation = await _occupationService.GetOccupationById(id);

            if (occupation is not null)
            {
                await _occupationService.Update(dto.Id, dto.NameOccupation);
            }

            return Ok(occupation);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteUser([FromRoute] int id)
        {
            var occupation = await _occupationService.GetOccupationById(id);

            if (occupation != null)
            {
                await _occupationService.Delete(id);
            }

            return Ok(occupation);
        }
    }
}
