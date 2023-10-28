using DevFreela.Application.ViewModel;
using DevFreela.Infrastructure.Persistense;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Queries.GetProjectById
{
    public class GetProjectByIdQueryHandler : IRequestHandler<GetProjectByIdQuery, ProjectDetailsViewModel>
    {
        private readonly DevFreelaDbContext _DbContext;

        public GetProjectByIdQueryHandler(DevFreelaDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public async Task<ProjectDetailsViewModel> Handle(GetProjectByIdQuery request, CancellationToken cancellationToken)
        {
            var project = _DbContext.Projects
              .Include(d => d.Client)
              .Include(d => d.Freelancer)
              .SingleOrDefault(p => p.Id == request.Id);

            var projectViewModel = new ProjectDetailsViewModel(
                project.Id,
                project.Title,
                project.Description,
                project.StarteAt,
                project.FinishAt,
                project.TotalConst,
                project.Client.FullName,
                project.Freelancer.FullName
                );
            return projectViewModel;
        }
    }
}
