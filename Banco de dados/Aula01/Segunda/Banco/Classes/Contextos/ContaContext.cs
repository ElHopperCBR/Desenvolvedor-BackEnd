using Banco.Classes.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Banco.Classes.Contextos
{
    internal class ContaContext : DbContext
    {
        //Propriedade - Representa as contas no BD
        public DbSet<Conta> contas { get; set; }

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeContrucao)
        {
            string config = @"Server=(localdb)\MSSQLLocalDB;Database=BancoDBContas;Trusted_Connection=True;TrustServerCertificate=True;";
            opcoesDeContrucao.UseSqlServer(config);
        }

        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Conta>(entidade =>
            {
                entidade.HasKey(e => e.Id );
                entidade.Property(e => e.NumeroDaConta);
                entidade.Property(e => e.TitularDaConta);
                entidade.Property(e => e.SaldoDaConta);
            });
        }
    }
}
