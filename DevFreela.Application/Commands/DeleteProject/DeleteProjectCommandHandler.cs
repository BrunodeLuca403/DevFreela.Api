using DevFreela.Core.Repositores;
using DevFreela.Infrastructure.Persistense;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Commands.DeleteProject
{
    public class DeleteProjectCommandHandler : IRequestHandler<DeleteProjectCommand, Unit>
    {
        private readonly IProjectRepository _projectRepository;

        public DeleteProjectCommandHandler(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public  async Task<Unit> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
        {
            var project = await _projectRepository.GetById(request.Id);

            project.Cancel();

            await _projectRepository.SaveChangesAsync();

           // var project = _dbContext.Projects.SingleOrDefault(p => p.Id == request.Id);
           // project.Cancel();
           //await _dbContext.SaveChangesAsync();

            return Unit.Value;

            await _projectRepository.DeleteProjectAsync(request.Id);
           
        }
    }
}
