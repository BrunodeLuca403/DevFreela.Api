using DevFreela.Application.InputModels;
using DevFreela.Application.Queries.GetUser;
using DevFreela.Core.Entitys;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UserController : ControllerBase
    {

        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetUser(int id)
        {
            //var user = _userService.GetUser(id);

            //if(user == null)
            //    return NotFound();

            //return Ok(user);

            var users = new GetUserQuery(id);

            var user = await _mediator.Send(users);

            return Ok(user);
        }

        [HttpPost]
        public IActionResult CreateUser(int id,[FromBody] CreateUserInputModel inputModel)
        {
           if(!ModelState.IsValid)
            {
                var message = ModelState
                    .SelectMany(ms => ms.Value.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();

                return BadRequest(message);
            }

            var user = _mediator.Send(inputModel);

            return CreatedAtAction(nameof(GetUser), new { id = user }, inputModel);
        }
    }
}
