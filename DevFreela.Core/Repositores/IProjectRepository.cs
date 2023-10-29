using DevFreela.Core.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Repositores
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetAll();
        Task<Project> GetById(int id);
        Task CreateCommentAsync(ProjectComment projectComment); 
        Task CreateProjectAsync(Project project);

        //Task UpdateProjectAsync(int id,Project project);
        //Task DeleteProjectAsync(int id);
        //Task StartAsync(Project project);
        //Task Finish(int id);
        Task SaveChangesAsync();
    }
}
