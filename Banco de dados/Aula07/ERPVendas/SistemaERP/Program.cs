using SistemaERP.Classes.Contextos;
using System.Drawing.Text;
using SQLitePCL;
using SistemaERP.Telas;

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
            SQLitePCL.Batteries.Init();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            ContextoUsuario contexto = new ContextoUsuario();
            contexto.Database.EnsureCreated();

            ContextoUltimoUsuario usuario = new ContextoUltimoUsuario();
            usuario.Database.EnsureCreated();

            ContextoPessoa pessoa = new ContextoPessoa();
            pessoa.Database.EnsureCreated();
            
            if (TestarConexaoBanco())
            {
                MessageBox.Show("Conexão realizada com sucesso!");
                //Application.Run(new Login()); Utilização futura
                Application.Run(new ERP());
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
                ContextoPessoa pessoa = new ContextoPessoa();
                return pessoa.Database.CanConnect();
            }
            catch (Exception e)
            {

                MessageBox.Show($"Erro: {e.Message}");
                return false;
            }
        }
    }
}