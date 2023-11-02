using DevFreela.Application.Commands.CreateComment;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Validators
{
    public class CreateCommentCommandValidator : AbstractValidator<CreateCommentCommand>
    {
        public CreateCommentCommandValidator()
        {
            RuleFor(p => p.Content).MaximumLength(250).WithMessage("O comentario tem um limite maximo de 250 caracteries");
        }
    }
}
