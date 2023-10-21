using Dapper;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModel;
using DevFreela.Infrastructure.Persistense;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Implementations
{
    public class SkillService : ISkillService
    {
        private readonly DevFreelaDbContext _DbContext;
        private readonly string _connectionString;

        public SkillService(DevFreelaDbContext dbContext, IConfiguration configuration)
        {
            _DbContext = dbContext;
            _connectionString = configuration.GetConnectionString("DevFreelaCs");
        }


        public List<SkillViewModel> GetAllSkill()
        {
            //var skill = _DbContext.Skills;

            //var SkillViewModel = skill.Select(s => new SkillViewModel(s.Id, s.Description)).ToList();

            //return SkillViewModel;

            using (var sqlconnection = new SqlConnection())
            {
                sqlconnection.Open();

                var script = "SELECT Id, description FROM Skills";
                return sqlconnection.Query<SkillViewModel>(script).ToList();
            }
        }
    }
}
