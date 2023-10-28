using Dapper;
using DevFreela.Application.ViewModel;
using DevFreela.Infrastructure.Persistense;
using MediatR;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Queries.GetAllSkills
{
    public class GetAllSkillsQueryHanlder : IRequestHandler<GetAllSkilsQuery, List<SkillViewModel>>
    {
        private readonly string _connectionString;

        public GetAllSkillsQueryHanlder(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString(_connectionString);
        }

        public async Task<List<SkillViewModel>> Handle(GetAllSkilsQuery request, CancellationToken cancellationToken)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                var script = "SELECT Id, Description FROM Skills";

                var skills = await sqlConnection.QueryAsync<SkillViewModel>(script);

                return skills.ToList();
            }
        }
    }
}
