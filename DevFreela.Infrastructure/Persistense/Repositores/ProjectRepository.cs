using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistense.Repositores
{
    public class ProjectRepository
    {
        private readonly DevFreelaDbContext _DbContext;

        public ProjectRepository(DevFreelaDbContext dbContext)
        {
            _DbContext = dbContext;
        }


    }
}
