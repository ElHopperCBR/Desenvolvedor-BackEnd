namespace Banco.Classes.Entidade
{
    internal class ContaEmpresacs : Conta
    {
		//Campos
		private double limite;


        //Propriedades
        protected double LimiteDeEmprestimo
		{
			get { return limite; }
			set { limite = value; }
		}
		//Construtores
        public ContaEmpresacs(int numeroDaConta, string titularDaConta, double limite) : base(numeroDaConta, titularDaConta)
        {
            LimiteDeEmprestimo = limite;
        }

        public ContaEmpresacs(int numeroDaConta, string titularDaConta, double saldoDaConta, double limite) : base(numeroDaConta, titularDaConta, saldoDaConta)
        {
            LimiteDeEmprestimo = limite;
        }

        //Metodos
        public override string ToString()
        {
            return $"Dados da conta:\n" +
                $"\tTitular: {TitularDaConta}\n" +
                $"\tNúmero: {NumeroDaConta}\n" +
                $"\tSaldo: {SaldoDaConta:c}\n" +
                $"\tLimite: {LimiteDeEmprestimo:c}\n";
        }

        public void Emprestimo(double quantia)
        {
            LimiteDeEmprestimo -= quantia;
            SaldoDaConta += quantia;
        }


	}
}
