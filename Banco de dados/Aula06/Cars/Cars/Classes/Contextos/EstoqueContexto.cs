using Cars.Classes.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Cars.Classes.Contextos
{
    internal class EstoqueContexto : DbContext
    {
        //Propriedade
        public DbSet<Estoque> Estoque { get; set; }

        
        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = @"Server=(localdb)\MSSQLLocalDB;Database=Automoveis;Trusted_Connection=True;TrustServerCertificate=True";
            opcoesDeConstrucao.UseSqlServer(caminho);
        }


        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Estoque>(entidade =>
            {
                entidade.HasKey(e => e.Id);

                entidade.Property(e => e.Modelo);

                entidade.Property(e => e.Tipo);

                entidade.Property(e => e.Valor);

                entidade.Property(e => e.Quantidade);

                entidade.Property(e => e.Foto);


            }

        );
        }


    }
}
