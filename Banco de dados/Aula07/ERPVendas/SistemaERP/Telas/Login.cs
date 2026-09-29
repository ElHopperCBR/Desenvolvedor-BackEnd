using SistemaERP.Classes.Contextos;
using SistemaERP.Classes.Entidades;
using SistemaERP.Telas;

namespace SistemaERP
{
    public partial class Login : Form
    {
        //Campos
        bool statusBT;

        //Construtor
        public Login()
        {
            ContextoUltimoUsuario usuario = new ContextoUltimoUsuario();
            InitializeComponent();
            statusBT = true;
            var check = usuario.ultimoUsuario.FirstOrDefault(e => e.EsqueceuSenha == true);

            if (check != null)
            {
                checkBox1.Checked = true;
                textBox1.Text = check.Nome;
                textBox2.Text = check.Senha;
            }
            else
            {
                MessageBox.Show("nada no banco");
            }

        }


        //Eventos       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Esqueceu a senha -> quando clicar
            Hide();
            Senha senha = new Senha();
            senha.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Registrar -> quando clicar
            Hide();
            Registrar registrar = new Registrar();
            registrar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Login -> quando clicar
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            const string caminhoImagemOlhoFechado = @"C:\Users\FIC\Documents\DEVBACKEND\Banco de dados\Aula07\ERPVendas\SistemaERP\Icones\olho.png";

            const string caminhoImagemOlhoAberto = @"C:\Users\FIC\Documents\DEVBACKEND\Banco de dados\Aula07\ERPVendas\SistemaERP\Icones\olhofechado.png";

            if (statusBT)
            {
                pictureBox1.ImageLocation = caminhoImagemOlhoFechado;
                textBox2.UseSystemPasswordChar = false;
                statusBT = false;
            }
            else
            {
                pictureBox1.ImageLocation = caminhoImagemOlhoAberto;
                textBox2.UseSystemPasswordChar = true;
                statusBT = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string senha = textBox2.Text;
            bool check = checkBox1.Checked;
            ContextoUltimoUsuario ultimo = new ContextoUltimoUsuario();

            if (check)
            {
                var usuario = ultimo.ultimoUsuario.FirstOrDefault(i => i.Id == 1);
                if (usuario != null)
                {
                    usuario.Nome = nome;
                    usuario.Senha = senha;
                    usuario.EsqueceuSenha = check;
                    ultimo.SaveChanges();
                }
                else
                {
                    UltimoUsuario usuario1 = new UltimoUsuario(nome, senha, check);
                    ultimo.ultimoUsuario.Add(usuario1);
                    ultimo.SaveChanges();
                }
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            bool status = checkBox1.Checked;
            ContextoUltimoUsuario ultimo = new ContextoUltimoUsuario();
            var usuario = ultimo.ultimoUsuario.FirstOrDefault(i => i.Id == 1);
            if (status)
            {
                if (usuario != null)
                {

                    usuario.EsqueceuSenha = true;
                    ultimo.SaveChanges();
                }
                else
                {
                    usuario.EsqueceuSenha = false;
                    ultimo.SaveChanges();
                }

            }
            else
            {
                usuario.EsqueceuSenha = false;
                ultimo.SaveChanges();
                checkBox1.Checked = false;
            }
        }
    }
}
