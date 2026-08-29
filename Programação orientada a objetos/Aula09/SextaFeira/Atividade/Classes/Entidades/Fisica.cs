using Atividade.Enumeracoes;
using Atividade.Interfaces;


namespace Atividade.Classes.Entidades
{
    internal class Pessoa_Fisica : Pessoa
    {
        //Campos
        private double gasto;

        //Propriedade
        public double GastoSaude
        {
            get { return gasto; }
            set { gasto = value; }
        }

        //Construtor
        public Pessoa_Fisica(string nome, double renda, IImposto imposto, Tipo perfil, double gasto) : base(nome, renda, imposto, perfil)
        {
            GastoSaude = gasto;
        }

        //Métodos
        public override string ExibirDados()
        {
            return base.ExibirDados() + $" ,Gasto: {GastoSaude:c}";
        }
    }
}
