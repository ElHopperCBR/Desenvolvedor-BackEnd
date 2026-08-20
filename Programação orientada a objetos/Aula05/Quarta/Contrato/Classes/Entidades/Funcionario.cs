using Contrato.Classes.Contratos;

namespace Contrato.Classes.Entidades
{
    internal class Funcionario
    {
        //Campos
		private string nome;
		private List<HoraContrato> contratos;


        //Propriedades
        protected string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        protected List<HoraContrato> Contratos	
		{
			get { return contratos; }
			set { contratos = value; }
		}

        //Construtor
        public Funcionario(string nome)
        {
            Nome = nome;
        }

        //Metodos
        public void AdicionarContrato(double valor, int horas)
        {
            HoraContrato contrato = new HoraContrato(horas, valor);
            Console.WriteLine(contrato);
            Contratos.Add(contrato);
        }

    }
}
