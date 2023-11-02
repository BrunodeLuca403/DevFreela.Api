using DevFreela.Application.Commands.CreateUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using System.Text.RegularExpressions;

namespace DevFreela.Application.Validators
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(p => p.Email)
                .NotEmpty()
                .EmailAddress()
                .WithMessage("E-mail  não valido!");

            RuleFor(p => p.Password)
                .Must(ValidPassword)
                .WithMessage("Senha deve conter pelo menos 8 caracteries, um numero e uma letr maiuscula e um caracteres especial");

            RuleFor(p => p.FullName)
                .NotNull()
                .NotEmpty()
                .WithMessage("Nome é Obrigatório");
        }

        public bool ValidPassword(string password)
        {
            var regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");

            return regex.IsMatch(password);
        }
    }
}
