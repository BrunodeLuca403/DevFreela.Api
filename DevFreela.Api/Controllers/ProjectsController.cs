using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ProjectsControllerc : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectsControllerc(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        public IActionResult Get(string query)
        {
            var projects = _projectService.GetAll(query);
            return Ok(projects);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var projects = _projectService.GetById(id);

            if (projects == null)
                return NotFound();

            return Ok(projects);
        }

        [HttpPost]
        public IActionResult Post([FromBody] NewProjectInputModel inputModel)
        {
            var project = _projectService.Create(inputModel);
            return CreatedAtAction(nameof(GetById), new { id = project }, inputModel);
        }

        [HttpPut]
        public IActionResult Update(int id, [FromBody] UpdateProjectInputModel inputModel)
        {
            if (inputModel.Id != id)
                return BadRequest();
            _projectService.UpDate(inputModel);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
             _projectService.Delete(id);
            return NoContent(); 
        }

        [HttpPost]
        public IActionResult PostCommet(int id, [FromBody] CreateCommentInputModel inputModel)
        {
            _projectService.CreateComment(inputModel);
            return NoContent();
        }

        [HttpPut]
        public IActionResult Start(int id)
        {
            _projectService.Start(id);
            return NoContent();
        }


        [HttpPut]
        public IActionResult Finish(int id)
        {
            _projectService.Finish(id);
            return NoContent();
        }

    }
}
