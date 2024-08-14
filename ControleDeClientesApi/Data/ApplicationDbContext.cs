using ControleDeClientesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeClientesApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cobranca> Cobrancas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cobranca>()
                .Property(c => c.Valor)
                .HasColumnType("decimal(18,2)");
        }
    }
}