namespace Banco.Classes.Entidades
{
    internal class ContaPessoaFisica
    {
		//Campos
		private int numero;
		private string titular;
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
		protected double SaldoDaConta
		{
			get { return saldo; }
			set { saldo = value; }
		}

		//Construtor
        public ContaPessoaFisica(string titularDaConta, int numeroDaConta)
        {
            TitularDaConta = titularDaConta;
            NumeroDaConta = numeroDaConta;
			SaldoDaConta = 0;
        }
        public ContaPessoaFisica(string titularDaConta, int numeroDaConta, double saldoDaConta) : this(titularDaConta, numeroDaConta)
        {
            SaldoDaConta = saldoDaConta;
        }

		//Metodos
		public void Saque(double quantia)
		{
			SaldoDaConta -= quantia;
		}

		public void Deposito(double quantia)
		{
			SaldoDaConta += quantia;
		}
    }
}
