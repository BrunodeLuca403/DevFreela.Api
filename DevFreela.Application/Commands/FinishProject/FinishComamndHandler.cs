
using DevFreela.Core.Repositores;
using DevFreela.Infrastructure.Persistense;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Commands.FinishProject
{
    public class FinishComamndHandler : IRequestHandler<FinishCommand, Unit>
    {
        private readonly IProjectRepository _projectRepository;

        public FinishComamndHandler(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<Unit> Handle(FinishCommand request, CancellationToken cancellationToken)
        {
            var project = await _projectRepository.GetById(request.Id);

            project.Finish();

            await _projectRepository.SaveChangesAsync();
            //await _projectRepository.Finish(request.Id);
            return Unit.Value;
        }
    }
}
