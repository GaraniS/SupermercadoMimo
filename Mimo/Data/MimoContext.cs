using Mimo.Models;
using Microsoft.EntityFrameworkCore;

namespace Mimo.Data
{
    public class MimoContext : DbContext
    {
        public MimoContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuração do relacionamento 1:N entre Cliente e Pedido
            modelBuilder.Entity<Pedido>()
               .HasOne(p => p.Cliente)
               .WithMany(c => c.Pedidos)
               .HasForeignKey(p => p.ClienteId);

            modelBuilder.Entity<Pedido>()
                .HasMany(p => p.Produtos);

            base.OnModelCreating(modelBuilder);
        }
    }
}
