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
        private readonly DevFreelaDbContext  _dbContext;

        public StartCommandHandler(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(StartCommand request, CancellationToken cancellationToken)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == request.Id);
            project.Start();
            await _dbContext.SaveChangesAsync();

            return Unit.Value;  
        }
    }
}
