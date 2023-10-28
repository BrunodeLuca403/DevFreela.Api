using DevFreela.Application.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Queries.GetAllProjects
{
    public class GetAllProjectsQuey : IRequest<List<ProjectViewModel>>
    {
        public GetAllProjectsQuey(string query)
        {
            this.query = query;
        }

        public string query { get; private set; }
    }
}
