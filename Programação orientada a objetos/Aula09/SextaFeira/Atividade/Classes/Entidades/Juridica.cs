using Atividade.Enumeracoes;
using Atividade.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade.Classes.Entidades
{
    internal class Juridica : Pessoa
    {
        //Campos
        private int qtd;

        //Propriedades
        protected int Quantidade
        {
            get { return qtd; }
            set { qtd = value; }        }

        //Construtor
        public Juridica(string nome, double renda, IImposto imposto, Tipo perfil, int quantidade) : base(nome, renda, imposto, perfil)
        {
            Quantidade = quantidade;
        }

        //Métodos
        public override string ExibirDados()
        {
            return base.ExibirDados() + $"Quantidade: {Quantidade}";
        }
    }
}
