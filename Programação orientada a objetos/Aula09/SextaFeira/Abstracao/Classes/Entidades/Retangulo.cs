using Abstracao.Enumeracoes;

namespace Abstracao.Classes.Entidades
{
    internal class Retangulo : Forma
    {
        //Campos
        private double largura;
        private double altura;

        //Propriedades
        protected double Largura
        {
            get { return largura; }
            set { largura = value; }
        }
        protected double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        //Construtor
        public Retangulo(Cor cor, double largura, double altura) : base(cor)
        {
            Largura = largura;
            Altura = altura;
        }

        public override void Area()
        {
            Console.WriteLine(Largura * Altura);
        }
    }
}
