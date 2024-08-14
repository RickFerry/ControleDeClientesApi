using ControleDeClientesApi.Models;

namespace ControleDeClientesApi.Services
{
    public interface ICobrancaService
    {
        IEnumerable<Cobranca?> GetAllCobrancas();
        Cobranca? GetCobrancaById(int id);
        void AddCobranca(Cobranca? cobranca);
        void UpdateCobranca(Cobranca? cobranca);
        void DeleteCobranca(int id);
    }
}