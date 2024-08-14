using ControleDeClientesApi.Models;
using FluentValidation;

namespace ControleDeClientesApi.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(u => u.Nome).NotEmpty();
            RuleFor(u => u.Email).NotEmpty().EmailAddress();
            RuleFor(u => u.Senha).NotEmpty().MinimumLength(6);
        }
    }
}