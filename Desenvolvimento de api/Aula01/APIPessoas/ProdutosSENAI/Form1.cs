using System.Net.Http.Json;

namespace ProdutosSENAI
{
    public partial class Form1 : Form
    {
        private readonly HttpClient clienteHttp = new() 
        {
            BaseAddress = new Uri("http://localhost:5197")        
        };
        public Form1()
        {
            InitializeComponent();
        }

        //Botão criar
        private void button1_Click(object sender, EventArgs e)
        {
            string mensagem;
            mensagem = clienteHttp.GetStringAsync("Produtos").Result;
            MessageBox.Show(mensagem);
        }
    }
}
