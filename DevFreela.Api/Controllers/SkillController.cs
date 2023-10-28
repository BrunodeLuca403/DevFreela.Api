using DevFreela.Application.Queries.GetAllSkills; 
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class SkillController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SkillController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //public SkillController(ISkillService skillService)
        //{
        //    _skillService = skillService;
        //}

        [HttpGet]
        public async Task<IActionResult> ListaSkill()
        {
            //var skill = _skillService.GetAllSkill();
            //return Ok(skill);

            var query = new GetAllSkilsQuery();
            var skill = await _mediator.Send(query);
            return Ok(skill);   
        }
    }
}
