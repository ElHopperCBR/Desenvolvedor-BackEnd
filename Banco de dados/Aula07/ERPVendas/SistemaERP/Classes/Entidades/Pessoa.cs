

namespace SistemaERP.Classes.Entidades
{
    internal class Pessoa : Usuario
    {

        //Propriedades
        public long CPF { get; set; }
        public DateTime DataNascimento { get; set; }

        public int Status {  get; set; }

        //Construtor
        public Pessoa(string nomeDoUsuario, string senhaDoUsuario, int regra, long cPF, DateTime dataNascimento, int status)
            : base(nomeDoUsuario, senhaDoUsuario, regra)
        {
            CPF = cPF;
            DataNascimento = dataNascimento;
            Status = status;
        }

        public Pessoa(string nomeDoUsuario, long cPF, DateTime dataNascimento, int status)
            : base(nomeDoUsuario)
        {
            NomeDoUsuario = nomeDoUsuario;
            CPF = cPF;
            DataNascimento = dataNascimento;
            Status = status;
        }
    }
}
