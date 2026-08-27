
using Master.Interfaces;

namespace Master.Classes.Entidades
{
    internal class Conta : IOperacoes
    {
        //Campos
        private string titular;
        private int numero;
        private double saldo;


        //Propriedades
        protected string TitularDaConta
        {
            get { return titular; }
            set { titular = value; }
        }
        protected int NumeroDaConta
        {
            get { return numero; }
            set { numero = value; }
        }
        public double SaldoDaConta
        {
            get { return saldo; }
            set { saldo = value; }
        }

        //Construtor
        public Conta(string titularDaConta, int numeroDaConta)
        {
            TitularDaConta = titularDaConta;
            NumeroDaConta = numeroDaConta;
            SaldoDaConta = 0;
        }
        public Conta(string titularDaConta, int numeroDaConta, double saldoDaConta) : this(titularDaConta, numeroDaConta)
        {
            SaldoDaConta = saldoDaConta;
        }

        //Métodos
        public void  Deposito(double qtd)
        {
            SaldoDaConta += qtd;
        }

        public virtual void Saque(double qtd)
        {
            SaldoDaConta -= qtd;
        }

        public virtual void ExibirDados()
        {
            Console.WriteLine($"Titular da conta: {TitularDaConta}\n" +
                $"Número da conta: {NumeroDaConta}\n" +
                $"Saldo da conta: {SaldoDaConta:c}");
        }
    }
}
