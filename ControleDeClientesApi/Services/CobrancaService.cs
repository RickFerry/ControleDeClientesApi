using ControleDeClientesApi.Data;
using ControleDeClientesApi.Models;

namespace ControleDeClientesApi.Services
{
    public class CobrancaService : ICobrancaService
    {
        private readonly ApplicationDbContext _context;

        public CobrancaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Cobranca?> GetAllCobrancas()
        {
            return _context.Cobrancas.ToList();
        }

        public Cobranca? GetCobrancaById(int id)
        {
            return _context.Cobrancas.Find(id);
        }

        public void AddCobranca(Cobranca? cobranca)
        {
            _context.Cobrancas.Add(cobranca);
            _context.SaveChanges();
        }

        public void UpdateCobranca(Cobranca? cobranca)
        {
            _context.Cobrancas.Update(cobranca);
            _context.SaveChanges();
        }

        public void DeleteCobranca(int id)
        {
            var cobranca = _context.Cobrancas.Find(id);
            if (cobranca != null)
            {
                _context.Cobrancas.Remove(cobranca);
                _context.SaveChanges();
            }
        }
    }
}