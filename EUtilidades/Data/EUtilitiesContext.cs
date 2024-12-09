using Microsoft.EntityFrameworkCore;
using EUtilidades.Models;

namespace EUtilidades.Data
{
    public class EUtilitiesContext : DbContext
    {
        public EUtilitiesContext(DbContextOptions<EUtilitiesContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemCarrinho> ItensCarrinho { get; set; }
    }
}
