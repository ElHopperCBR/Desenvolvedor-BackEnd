using Pessoas.Interfaces;

namespace Pessoas.Classes.Entidades
{
    internal class Funcionario : IPagamento
    {
        //Campos
        private string nome;
        private int jornada;
        private double valor;


        //Propriedades
        public string NomeFuncionario
        {
            get { return nome; }
            set { nome = value; }
        }
        protected int JornadaFuncionario
        {
            get { return jornada; }
            set { jornada = value; }
        }
        protected double ValorHora
        {
            get { return valor; }
            set { valor = value; }
        }

        //Construtor
        public Funcionario(string nomeFuncionario, int jornadaFuncionario, double valorHora)
        {
            NomeFuncionario = nomeFuncionario;
            JornadaFuncionario = jornadaFuncionario;
            ValorHora = valorHora;
        }

        //Métodos
        public virtual double Pagamento()
        {
            return JornadaFuncionario * ValorHora;
        }
    }
}
