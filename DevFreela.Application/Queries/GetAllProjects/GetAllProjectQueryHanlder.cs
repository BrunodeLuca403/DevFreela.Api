using DevFreela.Application.ViewModel;
using DevFreela.Infrastructure.Persistense;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Queries.GetAllProjects
{
    public class GetAllProjectQueryHanlder : IRequestHandler<GetAllProjectsQuey, List<ProjectViewModel>>
    {
        private readonly DevFreelaDbContext _DbContext;

        public GetAllProjectQueryHanlder(DevFreelaDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public async Task<List<ProjectViewModel>> Handle(GetAllProjectsQuey request, CancellationToken cancellationToken)
        {
            var projects = _DbContext.Projects;

            var projectViewModel = projects
                .Select(p => new ProjectViewModel(p.Id, p.Title, p.CreatedAt))
                .ToList();

            return projectViewModel;
        }
    }
}
