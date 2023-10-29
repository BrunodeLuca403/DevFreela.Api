using DevFreela.Core.Entitys;
using DevFreela.Core.Repositores;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistense.Repositores
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly DevFreelaDbContext _DbContext;
        private readonly string _connectionString;

        public ProjectRepository(DevFreelaDbContext dbContext, IConfiguration configuration)
        {
            _DbContext = dbContext;
            _connectionString = configuration.GetConnectionString("DevFreelaCs");
        }

        public async Task<List<Project>> GetAll()
        {
            return await _DbContext.Projects.ToListAsync();
        }

        public async Task<Project> GetById(int id)
        {
            return await _DbContext.Projects
              .Include(d => d.Client)
             .Include(d => d.Freelancer)
             .SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task CreateCommentAsync(ProjectComment projectComment)
        {
            await _DbContext.AddAsync(projectComment);
            await _DbContext.SaveChangesAsync();
        }

        public async Task CreateProjectAsync(Project project)
        {
            await _DbContext.AddAsync(project);
            await _DbContext.SaveChangesAsync();
        }

        //public async Task DeleteProjectAsync(int id)
        //{
        //   var project = await _DbContext.Projects.SingleOrDefaultAsync(p => p.Id == id);
        //    project.Cancel();
        //    await _DbContext.SaveChangesAsync();
        //}

        //public async Task StartAsync(Project project)
        //{         
        //    await _DbContext.SaveChangesAsync();
        //}

        //public async Task Finish(int id)
        //{
        //    var project = await _DbContext.Projects.SingleOrDefaultAsync(p => p.Id == id);
        //    project.Finish();
        //    await _DbContext.SaveChangesAsync();
        //}

        //public async Task UpdateProjectAsync(int id, Project project)
        //{
        //    var UpdateProject = await _DbContext.Projects.SingleOrDefaultAsync(p => p.Id == id);

        //    project.Update(UpdateProject.Title, UpdateProject.Description, UpdateProject.TotalConst);
        //    await _DbContext.SaveChangesAsync();
        //}

        public async Task SaveChangesAsync()
        {
            await _DbContext.SaveChangesAsync();
        }
    }
}
