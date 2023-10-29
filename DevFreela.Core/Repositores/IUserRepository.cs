using DevFreela.Core.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Repositores
{
    public interface IUserRepository
    {
        Task<User> GetUser(int id);

        Task CreateUser(User user);
    }
}
