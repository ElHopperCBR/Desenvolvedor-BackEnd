using APIPessoas.Models.Entidades;
using Microsoft.EntityFrameworkCore;

namespace APIPessoas.Models.Contextos
{
    public class ProdutosContexto : DbContext
    {
        public DbSet<Produtos> Produtos { get; set; }


        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = "";
            opcoesDeConstrucao.UseSqlite(caminho);
        }

    }
}
