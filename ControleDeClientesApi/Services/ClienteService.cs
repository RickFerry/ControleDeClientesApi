using ControleDeClientesApi.Data;
using ControleDeClientesApi.Models;

namespace ControleDeClientesApi.Services
{
    public class ClienteService : IClienteService
    {
        private readonly ApplicationDbContext _context;

        public ClienteService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Cliente?> GetAllClientes()
        {
            return _context.Clientes.ToList();
        }

        public Cliente? GetClienteById(int id)
        {
            return _context.Clientes.Find(id);
        }

        public void AddCliente(Cliente? cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void UpdateCliente(Cliente? cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }

        public void DeleteCliente(int id)
        {
            var cliente = _context.Clientes.Find(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
            }
        }
    }
}