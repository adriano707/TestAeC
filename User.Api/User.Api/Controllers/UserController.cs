using Microsoft.AspNetCore.Mvc;
using User.Api.Dto;
using User.Domain.Entities.Services;

namespace User.Api.Controllers
{
    [ApiController]
    [Route("user")]

    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetUserById([FromRoute] int id)
        {
            var user = _userService.GetUserById(id);
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] UserDto dto)
        {
            var user = _userService.Save(dto.Name, dto.BirthDate, dto.CPF);

            return Ok(user);
        }

        [HttpPost]
        [Route("{id}")]
        public async Task<IActionResult> EditUser([FromRoute]int id, [FromBody] UserDto dto)
        {
            var user = await _userService.GetUserById(id);

            if (user is not null)
            {
                await _userService.Update(dto.Id, dto.Name, dto.CPF, dto.BirthDate);
            }

            return Ok(user);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteUser([FromRoute] int id)
        {
            var user = await _userService.GetUserById(id);

            if (user != null)
            {
                await _userService.Delete(id);
            }

            return Ok(user);
        }
    }
}
