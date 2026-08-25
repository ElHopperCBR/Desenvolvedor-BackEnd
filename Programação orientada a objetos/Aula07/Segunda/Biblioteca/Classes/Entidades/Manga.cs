

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Biblioteca.Classes.Entidades
{
    internal class Manga : Item
    {
        //Campos
        private int numero;
        private string mes;

        //Propriedades
        protected int NumeroDoManga
        {
            get { return numero; }
            set { numero = value; }
        }

        protected string MesDePublicacao
        {
            get { return mes; }
            set { mes = value; }
        }


        //Construtores
        public Manga(DateTime anoPublicacao, string titulo, int numero, string mes) : base(anoPublicacao, titulo)
        {
            NumeroDoManga = numero;
            MesDePublicacao = mes;
        }

        public Manga(int quantidade, DateTime anoPublicacao, string titulo,int numero, string mes) : base(quantidade, anoPublicacao, titulo)
        {
            NumeroDoManga = numero;
            MesDePublicacao = mes;
        }

        //Metodos
        public override string Exibir()
        {
            return base.Exibir() + $"\t Nº do mangá: {NumeroDoManga}\n" +
                $"\t Mês de publicação: {MesDePublicacao}\n";
        }

    }
}
