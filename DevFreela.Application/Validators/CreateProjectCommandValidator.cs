using DevFreela.Application.Commands.CreateProject;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Validators
{
    public class CreateProjectCommandValidator : AbstractValidator<CreateProjectCommand>
    {
        public CreateProjectCommandValidator()
        {
            RuleFor(p => p.Description)
                .MaximumLength(255)
                .WithMessage("Tamanho Maximo de Descrição é de 255 caracteries");

            RuleFor(p => p.Title)
                .MaximumLength(30)
                .WithMessage("Tamanho maximo do Titulo é de 30 caracteries");


        }
    }
}
