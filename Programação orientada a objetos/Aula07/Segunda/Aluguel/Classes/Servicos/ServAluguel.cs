using Aluguel.Classes.Entidades;
using Aluguel.Interfaces;

namespace Aluguel.Classes.Servicos
{
    internal class ServAluguel
    {
		//Campos
		private double precoHora;
		private double precoDia;
		private ITaxaServ taxaServ;
		double pagamento, fatura, taxa;


        //Propriedade
        public double PrecoPorHora
		{
			get { return precoHora; }
			private set { precoHora = value; }
		}
		public double PrecoPorDia
		{
			get { return precoDia; }
			private set { precoDia = value; }
		}
		public ITaxaServ TaxaDeServico
		{
			get { return taxaServ; }
			private set { taxaServ = value; }
		}

		//Construtor
        public ServAluguel(double precoPorHora, double precoPorDia, ITaxaServ taxaDeServico)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            TaxaDeServico = taxaDeServico;
        }

		//Métodos
		public void CalcularFatura(AluguelCarro aluguelDeCarro)
		{
			TimeSpan duracao;			

			duracao = aluguelDeCarro.FimLocacao.Subtract(aluguelDeCarro.InicioLocacao);

            if (duracao.TotalHours <= 12.0)
            {
				pagamento = PrecoPorHora * duracao.TotalHours;
            }
            else
            {
				pagamento = PrecoPorDia * duracao.TotalDays;
            }

			taxa = taxaServ.Taxa(pagamento);

			fatura = pagamento + taxa;
        }

        public override string ToString()
        {
            return $"Pagamento sem taxa: {pagamento:c}" +
				$"\n Taxa: {taxa:c}" +
				$"\n Pagamento Total: {fatura:c}";
        }


	}
}
