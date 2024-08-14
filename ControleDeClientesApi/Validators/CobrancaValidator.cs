using ControleDeClientesApi.Models;
using FluentValidation;

namespace ControleDeClientesApi.Validators
{
    public class CobrancaValidator : AbstractValidator<Cobranca>
    {
        public CobrancaValidator()
        {
            RuleFor(c => c.Descricao).NotEmpty();
            RuleFor(c => c.Valor).GreaterThan(0);
            RuleFor(c => c.DataVencimento).NotEmpty();
        }
    }
}