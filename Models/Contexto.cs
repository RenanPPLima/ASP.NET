using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models   
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<Vendas> Vendas { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Clientes> Clientes { get; set;}

    }
}
