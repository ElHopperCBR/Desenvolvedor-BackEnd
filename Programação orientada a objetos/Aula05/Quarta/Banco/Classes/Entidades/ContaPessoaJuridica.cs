namespace Banco.Classes.Entidades
{
    internal class ContaPessoaJuridica : ContaPessoaFisica
    {
		//Campo
		private double limite;

        //Propriedades
        protected double LimiteDaConta
		{
			get { return limite; }
			set { limite = value; }
		}
        //Construtor
        public ContaPessoaJuridica(string titularDaConta, int numeroDaConta, double limite) : base(titularDaConta, numeroDaConta)
        {
            LimiteDaConta = limite;
        }

        public ContaPessoaJuridica(string titularDaConta, int numeroDaConta, double saldoDaConta, double limite) : base(titularDaConta, numeroDaConta, saldoDaConta)
        {
            LimiteDaConta = limite;
        }

        public void Limite(double quantia)
        {
            SaldoDaConta += quantia;
        }
    }
}
