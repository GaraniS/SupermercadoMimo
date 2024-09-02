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
                .HasForeignKey(p => p.ClienteId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configuração do relacionamento 1:N entre Pedido e ItemPedido
            modelBuilder.Entity<ItemPedido>()
                .HasOne(i => i.Pedido)
                .WithMany(p => p.ItensPedido)
                .HasForeignKey(i => i.PedidoId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configuração do relacionamento 1:N entre Produto e ItemPedido
            modelBuilder.Entity<ItemPedido>()
                .HasOne(i => i.Produto)
                .WithMany(p => p.ItensPedido)
                .HasForeignKey(i => i.ProdutoId)
                .OnDelete(DeleteBehavior.Restrict); // Opcionalmente, pode usar DeleteBehavior.Cascade

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Mimo.Models.ItemPedido> ItemPedido { get; set; } = default!;
    }
}
