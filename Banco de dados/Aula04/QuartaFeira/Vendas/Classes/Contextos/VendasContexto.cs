using Microsoft.EntityFrameworkCore;
using VendasSenai.Classes.Entidades;

namespace VendasSenai.Classes.Contextos
{
    internal class VendasContexto : DbContext
    {
        //Propriedade
        public DbSet<Vendas1> vendas { get; set; }

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = @"Server=(localdb)\MSSQLLocalDB;Database=CamisasSENAI;Trusted_Connection=True;TrustServerCertificate=True";
            opcoesDeConstrucao.UseSqlServer(caminho);
        }
        
        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
                modeloDeConstrucao.Entity<Vendas1>(entidade =>
                {
                    entidade.HasKey(e => e.Id);
                    entidade.Property(e => e.DataCompra);
                    entidade.Property(e => e.Tipo);
                    entidade.Property(e => e.Marca);
                    entidade.Property(e => e.Faturamento);
                    entidade.Property(e => e.Lucro);
                }

            );
        }
    }
}
