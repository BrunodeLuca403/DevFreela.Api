using DevFreela.Application.ViewModel;
using DevFreela.Core.Repositores;
using DevFreela.Infrastructure.Persistense;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Queries.GetUser
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserViewModel>
    {
        //private readonly DevFreelaDbContext _DbContext;

        //public GetUserQueryHandler(DevFreelaDbContext dbContext)
        //{
        //    _DbContext = dbContext;
        //}

        private readonly IUserRepository _userRepository;

        public GetUserQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserViewModel> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            //var user = _DbContext.Users.FirstOrDefault(p => p.Id == request.Id);

            var user = await _userRepository.GetUser(request.Id);

            var users = new UserViewModel(user.FullName, user.Email);

            return users;

        }
    }
}
