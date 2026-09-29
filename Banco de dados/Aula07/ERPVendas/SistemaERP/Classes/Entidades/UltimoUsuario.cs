
namespace SistemaERP.Classes.Entidades
{
    internal class UltimoUsuario
    {

        //Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public bool EsqueceuSenha { get; set; }

        //Construtor
        public UltimoUsuario(string nome, string senha, bool esqueceuSenha)
        {
            Nome = nome;
            Senha = senha;
            EsqueceuSenha = esqueceuSenha;
        }

        //Métodos
        public void statusEsqueceuSenha(bool esqueceu)
        {
            EsqueceuSenha = esqueceu;
        }

    }
}
