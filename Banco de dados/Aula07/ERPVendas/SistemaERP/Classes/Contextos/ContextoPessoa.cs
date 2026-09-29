using Microsoft.EntityFrameworkCore;
using SistemaERP.Classes.Entidades;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaERP.Classes.Contextos
{
    internal class ContextoPessoa : DbContext
    {
        //Propriedade
        public DbSet<Pessoa> Pessoas { get; set; }

        //Método
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {

            string string_de_conexao = Environment.GetEnvironmentVariable("string_de_conexao")?.Trim('"'); ;

            opcoesDeConstrucao.UseNpgsql(string_de_conexao);
        }


        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Pessoa>(entidade =>
            {
                entidade.HasKey(e => e.Id);
                entidade.Property(e => e.NomeDoUsuario);
                entidade.Property(e => e.CPF);
                entidade.Property(e => e.DataNascimento);
                entidade.Property(e => e.Status);

                // Ignorar propriedades não mapeadas
                entidade.Ignore(e => e.SenhaDoUsuario);
                entidade.Ignore(e => e.Regra);
            });
        }
    }
}
