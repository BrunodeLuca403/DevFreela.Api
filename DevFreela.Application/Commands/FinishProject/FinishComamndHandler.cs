
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
        private readonly DevFreelaDbContext _DbContext;

        public FinishComamndHandler(DevFreelaDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public async Task<Unit> Handle(FinishCommand request, CancellationToken cancellationToken)
        {
            var project = _DbContext.Projects.SingleOrDefault(p => p.Id == request.Id);
            project.Finish();
            await _DbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
