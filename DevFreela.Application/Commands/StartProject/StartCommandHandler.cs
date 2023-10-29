using DevFreela.Core.Repositores;
using DevFreela.Infrastructure.Persistense;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Commands.StartProject
{
    public class StartCommandHandler : IRequestHandler<StartCommand, Unit>
    {
        private readonly IProjectRepository _projectRepository;

        public StartCommandHandler(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<Unit> Handle(StartCommand request, CancellationToken cancellationToken)
        {
            var project =  await _projectRepository.GetById(request.Id);
            project.Start();
            await _projectRepository.SaveChangesAsync();
            return Unit.Value;  
        }
    }
}
