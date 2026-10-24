using CasasBahia.Classes.Models.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CasasBahia.Classes.Models.Contextos
{
    public class ContextoLogin : DbContext
    {
        public DbSet<Logins> Logins { get; set; }


        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = @"Server=(localdb)\MSSQLLocalDB;Database=ProdutosCasasBahia;Trusted_Connection=True;TrustServerCertificate=True";
            opcoesDeConstrucao.UseSqlServer(caminho);
        }


        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Logins>(entidade =>
                {
                    entidade.HasKey(e => e.Id);
                    entidade.Property(e => e.Usuario);
                    entidade.Property(e => e.Senha);
                    entidade.Property(e => e.Regra);
                }
            );
        }


    }
}
