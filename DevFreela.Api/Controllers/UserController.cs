using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Core.Entitys;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetUser(int id)
        {
            var user = _userService.GetUser(id);

            if(user == null)
                return NotFound();

            return Ok(user);
        }

        [HttpPost]
        public IActionResult CreateUser(int id,[FromBody] CreateUserInputModel inputModel)
        {
            var user = _userService.Create(inputModel);
            return CreatedAtAction(nameof(GetUser), new { id = user }, inputModel);
        }
    }
}
