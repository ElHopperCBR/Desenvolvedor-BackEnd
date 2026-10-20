using System.ComponentModel.DataAnnotations;

namespace Banco.Classes.Models.Entidades
{
    public class ContaBancaria
    {


        /// <summary>
        /// Cria o número da conta bancário no database.
        /// </summary>
        [Key]
        public int NumeroConta { get; set; }

        /// <summary>
        /// Cria o titular da conta bancaria
        /// </summary>
        [Required]
        public string TitularConta { get; set; }

        /// <summary>
        /// Saldo da conta, este valor pode ficar negativo ou ser zero.
        /// </summary>
        [Required]
        public decimal Saldo { get; set; }

        public ContaBancaria(string titularConta, decimal saldo)
        {
            TitularConta = titularConta;
            Saldo = saldo;
        }

    }
}
