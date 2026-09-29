using System.ComponentModel;

namespace SistemaERP.Classes.Enumeracoes
{
    internal enum StatusUsuario
    {
        [Description("Aguardando aprovação...")]
        Aguardando = 0,
        [Description("Usuário Aprovado")]
        Aprovado = 1,
        [Description("Usuário Reprovado")]
        Reprovado = 2
    }
}
