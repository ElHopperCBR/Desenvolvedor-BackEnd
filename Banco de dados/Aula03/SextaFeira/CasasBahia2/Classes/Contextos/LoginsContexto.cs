
using CasasBahia2.Classes.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CasasBahia2.Classes.Contextos
{
    internal class LoginsContexto : DbContext
    {
        //Propriedade
        public DbSet<Logins> Logins { get; set; }

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeContrucao)
        {
            string caminho = @"Server=(localdb)\MSSQLLocalDB;Database=ProdutosCasasBahia;Trusted_Connection=True;TrustServerCertificate=True;";
            opcoesDeContrucao.UseSqlServer(caminho);
        }

        protected override void OnModelCreating(ModelBuilder modeloDeContrucao)
        {
            modeloDeContrucao.Entity<Logins>(entidade =>
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
