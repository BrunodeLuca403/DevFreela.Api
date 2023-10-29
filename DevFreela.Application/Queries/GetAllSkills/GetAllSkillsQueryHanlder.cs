using Dapper;
using DevFreela.Application.ViewModel;
using DevFreela.Core.DTOs;
using DevFreela.Core.Repositores;
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
    public class GetAllSkillsQueryHanlder : IRequestHandler<GetAllSkilsQuery, List<SkillDTO>>
    {
        private readonly ISkillRepository _skillRepository;

        public GetAllSkillsQueryHanlder(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }

        public async Task<List<SkillDTO>> Handle(GetAllSkilsQuery request, CancellationToken cancellationToken)
        {
            return await _skillRepository.GetAll();

        }
    }
}
