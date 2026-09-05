
using CasasBahia2.Classes.Contextos;
using CasasBahia2.Classes.Entidades;

namespace CasasBahia2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

        }

        //Tab 1 - Botão para cadastrar item
        private void button1_Click(object sender, EventArgs e)
        {
            ProdutosContexto contexto = new ProdutosContexto();
            string cadastroNomeProduto = textBox1.Text;
            int quantitdadeDeProduto = int.Parse(textBox2.Text);
            decimal valorDoProduto = decimal.Parse(textBox3.Text);

            Produtos produtos = new Produtos(cadastroNomeProduto, quantitdadeDeProduto, valorDoProduto);
            contexto.Produtos.Add(produtos);
            contexto.SaveChanges();
            MessageBox.Show("Cadastro realizado com sucesso");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        //Tab 2 - Botão para pesquisar item
        private void button2_Click(object sender, EventArgs e)
        {
            ProdutosContexto contextos = new ProdutosContexto();
            var produto = contextos.Produtos.FirstOrDefault(p => p.CodigoDoProduto == int.Parse(textBox4.Text));
            if (produto == null)
            {
                MessageBox.Show("Produto não cadastrado");
            }
            else
            {
                MessageBox.Show(" - Produto encontrado -" +
                    $"Nome do produto: {produto.NomeDoProduto}" +
                    $"Quantidade em estoque: {produto.QuantidadeDeProduto}" +
                    $"Preço do produto: {produto.ValorDoProduto:c}");
            }
            textBox4.Text = "";
        }

        //Tab 3 - Botão para editar/pesquisar item 
        private void button3_Click(object sender, EventArgs e)
        {

        }


    }
}
