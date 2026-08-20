namespace Pedido.Classes.Entidades
{
    //Objeto que pode exisitr de forma independente
    internal class Funcionario
    {
        //1° - Campos
        private string nome;

        //2° - Propriedades 
        protected string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        //3° - Construtor
        public Funcionario(string nome)
        {
            Nome = nome;
        }

    }
}
