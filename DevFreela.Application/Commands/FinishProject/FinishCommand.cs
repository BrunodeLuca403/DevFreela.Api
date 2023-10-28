﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Commands.FinishProject
{
    public class FinishCommand : IRequest<Unit>
    {
        public FinishCommand(int id)
        {
            Id = id;
        }

        public int Id{ get;  private set; }
    }
}
