

namespace SistemaERP.Classes.Services
{
    internal static class TelaLogin
    {
        //Campo
        static Login login;

        //Método
        public static void AbrirTela()
        {
            login = new Login();
            login.Show();
        }
    }
}
