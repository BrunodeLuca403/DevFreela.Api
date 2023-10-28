using DevFreela.Application.Commands.CreateComment;
using DevFreela.Application.Commands.CreateProject;
using DevFreela.Application.Commands.DeleteProject;
using DevFreela.Application.Commands.FinishProject;
using DevFreela.Application.Commands.StartProject;
using DevFreela.Application.Commands.UpdateProject;
using DevFreela.Application.InputModels;
using DevFreela.Application.Queries.GetAllProjects;
using DevFreela.Application.Queries.GetProjectById;
using DevFreela.Application.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ProjectsControllerc : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProjectsControllerc( IMediator mediatR)
        {
            _mediator = mediatR;
        }

        [HttpGet]
        public async  Task<IActionResult> Get(string query)
        {
            var getAllProjectsQuery = new GetAllProjectsQuey(query);
            var projects = await _mediator.Send(getAllProjectsQuery);
            //var projects = _projectService.GetAll(query);
            return Ok(projects);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //var projects = _projectService.GetById(id);

            //if (projects == null)
            //    return NotFound();

            //return Ok(projects);
            var projects = new GetProjectByIdQuery(id);
            var project = _mediator.Send(projects);
            return Ok(project);

        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateProjectCommand command)
        {
           // var project = _projectService.Create(inputModel);

            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

        [HttpPut]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateProjectCommand command)
        {
            if (command.Id != id)
                return BadRequest();

            await _mediator.Send(command);
           // _projectService.UpDate(inputModel);
            return NoContent(); 
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var project = new DeleteProjectCommand(id);

            await _mediator.Send(project);
             //_projectService.Delete(id);
            return NoContent(); 
        }

        [HttpPost]
        public async Task<IActionResult> PostCommet(int id, [FromBody] CreateCommentCommand createComment)
        {
           await _mediator.Send(createComment);
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Start(int id)
        {
            var project = new StartCommand(id);
            await _mediator.Send(project);


            return NoContent();
        }


        [HttpPut]
        public async Task<IActionResult> Finish(int id)
        {
            var project = new FinishCommand(id);
            await _mediator.Send(project);
            return NoContent();
        }

    }
}
