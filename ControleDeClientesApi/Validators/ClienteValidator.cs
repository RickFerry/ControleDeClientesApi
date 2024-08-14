using ControleDeClientesApi.Models;
using FluentValidation;

namespace ControleDeClientesApi.Validators
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(c => c.Nome).NotEmpty();
            RuleFor(c => c.Documento).NotEmpty();
            RuleFor(c => c.Telefone).NotEmpty();
            RuleFor(c => c.Endereco).NotEmpty();
        }
    }
}