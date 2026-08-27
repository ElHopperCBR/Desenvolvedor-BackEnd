
namespace Pessoas.Classes.Entidades
{
    internal class Terceiro : Funcionario
    {
        //Campos
		private double despesa;

        //Propriedade
        protected double DespesaAdicional
		{
			get { return despesa; }
			set { despesa = value; }
		}

        //Construtor
        public Terceiro(string nomeFuncionario, int jornadaFuncionario, double valorHora) : base(nomeFuncionario, jornadaFuncionario, valorHora)
        {
            DespesaAdicional = (ValorHora * JornadaFuncionario) * 0.2;
        }

        //Métodos
        public override double Pagamento()
        {
            return base.Pagamento() + DespesaAdicional;
        }

	}
}
