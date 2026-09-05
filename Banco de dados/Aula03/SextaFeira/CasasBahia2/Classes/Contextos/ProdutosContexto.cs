using CasasBahia2.Classes.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasasBahia2.Classes.Contextos
{
    internal class ProdutosContexto : DbContext
    {
        //Propriedade
        public DbSet<Produtos> Produtos { get; set; }

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeContrucao)
        {
            string caminho = @"Server=(localdb)\MSSQLLocalDB;Database=ProdutosCasasBahia;Trusted_Connection=True;TrustServerCertificate=True;";
            opcoesDeContrucao.UseSqlServer(caminho);
        }

        protected override void OnModelCreating(ModelBuilder modeloDeContrucao)
        {
            modeloDeContrucao.Entity<Produtos>(entidade =>
            {
                entidade.HasKey(e => e.CodigoDoProduto);
                entidade.Property(e => e.NomeDoProduto);
                entidade.Property(e => e.QuantidadeDeProduto);
                entidade.Property(e => e.ValorDoProduto);
            }
            );
        }
    }
}
