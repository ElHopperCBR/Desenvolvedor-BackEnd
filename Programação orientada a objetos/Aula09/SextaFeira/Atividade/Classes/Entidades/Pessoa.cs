using Atividade.Enumeracoes;
using Atividade.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade.Classes.Entidades
{
    abstract internal class Pessoa : IDados
    {   
        //Campos
        private string nome;
        private double renda;
        private IImposto imposto;
        private Tipo perfil;


        //Propriedades
        protected string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        protected double Renda
        {
            get { return renda; }
            set { renda = value; }
        }
        public IImposto Imposto
        {
            get { return imposto; }
            set { imposto = value; }
        }
        public Tipo Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }

        //Construtor
        protected Pessoa(string nome, double renda, IImposto imposto, Tipo perfil)
        {
            Nome = nome;
            Renda = renda;
            Imposto = imposto;
            Perfil = perfil;
        }



        //Métodos
        public virtual string ExibirDados()
        {
            return ($"Tipo: {Perfil},Nome: {nome},Renda: {Renda:c},Imposto: {Imposto:c}"); 
        }
    }
}
