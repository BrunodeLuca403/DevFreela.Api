using DevFreela.Application.ViewModel;
using DevFreela.Core.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Queries.GetAllSkills
{
    public class GetAllSkilsQuery : IRequest<List<SkillDTO>>
    {
    }
}
