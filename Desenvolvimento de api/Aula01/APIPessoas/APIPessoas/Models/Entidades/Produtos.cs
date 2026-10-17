using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace APIPessoas.Models.Entidades
{
    public class Produtos
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Para cadastrar um produto inserir um nome de um produto")]
        [Length(2, 15, ErrorMessage = "Tamanho minimo do nome 2 letras e maximo 15 letras")]
        public string Nome { get; set; }
        
        [Required]
        [Range(0,30000)]
        public decimal Preco { get; set; }
        
        [Required]
        public string Descricao { get; set; }

        [Required]
        [Range(0,100)]
        public int Quantidade { get; set; }

        public Produtos(string nome, decimal preco, string descricao, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Descricao = descricao;
            Quantidade = quantidade;
        }

    }
}
