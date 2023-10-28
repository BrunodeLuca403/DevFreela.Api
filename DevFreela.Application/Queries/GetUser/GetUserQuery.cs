using DevFreela.Application.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Queries.GetUser
{
    public class GetUserQuery : IRequest<UserViewModel>
    {
        public GetUserQuery(int id)
        {
            Id = id;
            //Name = name;
            //Email = email;
        }

        public int Id { get; private set; }
        //public string Name { get; private set; }
        //public string Email { get; private set; }
    }
}
