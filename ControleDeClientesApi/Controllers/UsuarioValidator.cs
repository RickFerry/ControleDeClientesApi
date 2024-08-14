using ControleDeClientesApi.Models;
using FluentValidation;

namespace ControleDeClientesApi.Controllers
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