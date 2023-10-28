using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModel;
using DevFreela.Core.Entitys;
using DevFreela.Infrastructure.Persistense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Implementations
{
    public class UserService : IUserService
    {

        private readonly DevFreelaDbContext _dbContext;

        public UserService(DevFreelaDbContext DbContext)
        {
            _dbContext = DbContext;
        }
        public int Create(CreateUserInputModel inputModel)
        {
            var users = new User(inputModel.FullName, inputModel.Password, inputModel.Email, inputModel.BirthDate);
                _dbContext.Users.Add(users);
            _dbContext.SaveChanges();

            return users.Id;
            
        }

        public UserViewModel GetUser(int id)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Id == id);

            if (user == null)
            {
                return null;
            }

            return new UserViewModel(user.FullName, user.Email);
        }
    }
}
