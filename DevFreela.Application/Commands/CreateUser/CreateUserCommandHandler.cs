using DevFreela.Core.Entitys;
using DevFreela.Core.Repositores;
using DevFreela.Infrastructure.Persistense;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IUserRepository _UserRepository;

        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            _UserRepository = userRepository;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User(request.FullName, request.Password, request.Email, request.BirthDate);

            await _UserRepository.CreateUser(user);

            return user.Id;
        }
    }
}
