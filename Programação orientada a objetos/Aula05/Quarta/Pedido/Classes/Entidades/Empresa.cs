namespace Pedido.Classes.Entidades
{
    internal class Empresa
    {
		//1° - Campos
		private string nome;
		private List<Funcionario> funcionarios;


        //2° - Propriedades
        protected List<Funcionario> ListaFuncionarios
		{
			get { return funcionarios; }
			set { funcionarios = value; }
		}		
		protected string NomeDaEmpresa
		{
			get { return nome; }
			set { nome = value; }
		}

		//3° - Construtor
        public Empresa(string nomeDaEmpresa)
        {
            NomeDaEmpresa = nomeDaEmpresa;
			ListaFuncionarios = new List<Funcionario>();
        }

		//4° - Métodos
		public void AdicionarFuncionario(Funcionario funcionario)
		{
			ListaFuncionarios.Add(funcionario);
		}
	}
}
