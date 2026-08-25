using Biblioteca.Interfaces;

namespace Biblioteca.Classes.Entidades
{
    internal class Item : IMovimentacao, IInformacoes
    {

        //Campos
        private string titulo;
        private DateTime ano;
        private int quantidade;



        //Propriedades
        protected int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        protected DateTime AnoPublicacao
        {
            get { return ano; }
            set { ano = value; }
        }

        protected string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        //Construtor
        public Item(DateTime anoPublicacao, string titulo)
        {
            AnoPublicacao = anoPublicacao;
            Titulo = titulo;
            Quantidade = 0;
           
        }

        public Item(int quantidade, DateTime anoPublicacao, string titulo) : this(anoPublicacao, titulo) 
        {          
            Quantidade = quantidade;
        }

        //Métodos
        public void Devolver(int quantia)
        {
            Quantidade += quantia;
        }

        public void Emprestar(int quantia)
        {
            Quantidade -= quantia;
        }

        public virtual string Exibir()
        {
            return ($"Dados do item:\n" +
                $"\tTitulo: {Titulo}\n" +
                $"\tAno de publicação: {AnoPublicacao}\n" +
                $"\tQuantidade disponivel: {Quantidade}\n");
        }
    }
}