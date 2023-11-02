using DevFreela.Application.Commands.UpdateProject;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Validators
{
    public class UpdateProjectCommandValidator : AbstractValidator<UpdateProjectCommand>
    {
        public UpdateProjectCommandValidator()
        {
            RuleFor(p => p.Title)
                .MaximumLength(50)
                .WithMessage("O titulo so pode ter no maximo 50 caracteries");

            RuleFor(p => p.Description)
                .MaximumLength(500)
                .WithMessage("A descrição tem o limite maximo de 500 caracteries");
        }
    }
}
