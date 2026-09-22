using SistemaERP.Classes.Contextos;
using System.Drawing.Text;

namespace SistemaERP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            ContextoUsuario contexto = new ContextoUsuario();
            contexto.Database.EnsureCreated();
            
            if (TestarConexaoBanco())
            {
                MessageBox.Show("Conexão realizada com sucesso!");
                Application.Run(new Login());
            }
            else
            {
                MessageBox.Show("Falha ao conectar ao banco de dados");
            }
            
        }

        private static bool TestarConexaoBanco()
        {
            try
            {
                ContextoUsuario contexto = new ContextoUsuario();
                return contexto.Database.CanConnect();
            }
            catch (Exception e)
            {

                MessageBox.Show($"Erro: {e.Message}");
                return false;
            }
        }
    }
}