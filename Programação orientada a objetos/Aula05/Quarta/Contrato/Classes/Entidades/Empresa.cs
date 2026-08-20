namespace Contrato.Classes.Entidades
{
    internal class Empresa
    {
        //Campos
		private string nome;
		private Funcionario funcionario;

        //Propriedades
        protected string NomeDaEmpresa
        {
            get { return nome; }
            set { nome = value; }
        }
        protected Funcionario Funcionario
		{
			get { return funcionario; }
			set { funcionario = value; }
		}
        //Construtor
        public Empresa(string nomeDaEmpresa, string nomeFuncionario)
        {
            NomeDaEmpresa = nomeDaEmpresa;
            Funcionario = new Funcionario(nomeFuncionario);
        }
        //Metodos
        public void RegistrarContratoFuncionario(double valor, int horas)
        {
            Funcionario.AdicionarContrato(valor, horas);
        }
	}
}
