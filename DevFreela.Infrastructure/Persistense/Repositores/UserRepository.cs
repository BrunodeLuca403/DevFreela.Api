using DevFreela.Core.Entitys;
using DevFreela.Core.Repositores;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistense.Repositores
{
    public class UserRepository : IUserRepository
    {
        private readonly DevFreelaDbContext _DbContext;

        public UserRepository(DevFreelaDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public async Task CreateUser(User user)
        {
            await _DbContext.AddAsync(user);
            await _DbContext.SaveChangesAsync();
        }

        public async Task<User> GetUser(int id)
        {
            return await _DbContext.Users.FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
