
using Microsoft.EntityFrameworkCore;
using Restaurante.Classes.Entidades;

namespace Restaurante.Classes.Contextos
{
    internal class PratosContexto : DbContext
    {
        //Propriedade
        public DbSet<Pratos> Pratos { get; set; }


        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = @"Server=(localdb)\MSSQLLocalDB;Database=Sensei;Trusted_Connection=True;TrustServerCertificate=True";
            opcoesDeConstrucao.UseSqlServer(caminho);
        }


        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Pratos>(entidade =>
            {
                entidade.HasKey(e => e.Id);

                entidade.Property(e => e.Nome_do_prato);

                entidade.Property(e => e.Preco);

                entidade.Property(e => e.Foto_do_prato);

            }

        );
        }


    }
}
