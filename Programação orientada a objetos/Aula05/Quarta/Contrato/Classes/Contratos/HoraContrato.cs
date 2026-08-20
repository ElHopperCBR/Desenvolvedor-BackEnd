namespace Contrato.Classes.Contratos
{
    internal class HoraContrato
    {
		//Campos
		private int horas;
		private double valor;


        //Propriedades
        protected int HorasTrabalhadas
		{
			get { return horas; }
			set { horas = value; }
		}
		protected double ValorPorHora
		{
			get { return valor; }
			set { valor = value; }
		}

		//Construtor
        public HoraContrato(int horasTrabalhadas, double valorPorHora)
        {
            HorasTrabalhadas = horasTrabalhadas;
            ValorPorHora = valorPorHora;
        }

		//Metodo
		public double Pagamento()
		{
			return ValorPorHora * HorasTrabalhadas;
		}



	}
}
