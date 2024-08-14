using ControleDeClientesApi.Data;
using ControleDeClientesApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControleDeClientesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CobrancasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CobrancasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // POST: api/Cobrancas
        [HttpPost]
        public async Task<ActionResult<Cobranca>> PostCobranca(Cobranca? cobranca)
        {
            _context.Cobrancas.Add(cobranca);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCobranca", new { id = cobranca.Id }, cobranca);
        }

        // GET: api/Cobrancas/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Cobranca>> GetCobranca(int id)
        {
            var cobranca = await _context.Cobrancas.FindAsync(id);

            if (cobranca == null)
            {
                return NotFound();
            }

            return cobranca;
        }

        // GET: api/Cobrancas/Cliente/{clienteId}
        [HttpGet("Cliente/{clienteId}")]
        public async Task<ActionResult<IEnumerable<Cobranca>>> GetCobrancasByCliente(int clienteId)
        {
            var cobrancas = await _context.Cobrancas
                .Where(c => c.ClienteId == clienteId)
                .ToListAsync();

            var cobrancasComAtraso = cobrancas.Select(c => new
            {
                c.Id,
                c.Descricao,
                c.Valor,
                c.DataVencimento,
                c.Pago,
                EmAtraso = !c.Pago && c.DataVencimento < DateTime.Now
            });

            return Ok(cobrancasComAtraso);
        }
    }
}