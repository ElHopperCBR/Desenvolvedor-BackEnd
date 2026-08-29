using Abstracao.Enumeracoes;
using Abstracao.Interfaces;

namespace Abstracao.Classes.Entidades
{
    abstract internal class Forma : IGeometria
    {
        //Campo
        Cor cor;


        //Construtor
        public Forma(Cor cor)
        {
            this.cor = cor;
        }


        /// <summary>
        /// Método para calcular a área da forma
        /// </summary>      
        //Método
        public abstract void Area();

        public string Cor() => (cor.ToString());

    }
}
