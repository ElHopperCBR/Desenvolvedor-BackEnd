namespace Biblioteca.Classes.Entidades
{
    internal class Livro : Item
    {
        //Campos
        private string autor;
        private int paginas;

        //Propriedades
        protected string AutorLivro
        {
            get { return autor; }
            set { autor = value; }
        }

        protected int PaginasLivro
        {
            get { return paginas; }
            set { paginas = value; }
        }

        //Construtores
        public Livro(DateTime anoPublicacao, string titulo, string autor, int pag) : base(anoPublicacao, titulo)
        {
            AutorLivro = autor;
            PaginasLivro = pag;
        }

        public Livro(int quantidade, DateTime anoPublicacao, string titulo, string autor, int pag) : base(quantidade, anoPublicacao, titulo)
        {
            AutorLivro = autor;
            PaginasLivro = pag;
        }

        //Metodos
        public override string Exibir()
        {
            return base.Exibir() +
                $"\t Autor do livro: {AutorLivro}\n" +
                $"\t Nº de páginas : {PaginasLivro}\n";
        }
    }
}
