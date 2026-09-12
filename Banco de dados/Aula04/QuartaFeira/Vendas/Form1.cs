using Microsoft.IdentityModel.Tokens;
using VendasSenai.Classes.Contextos;

namespace Vendas
{
    public partial class Form1 : Form
    {
        //Campos
        VendasContexto vendasContexto = new VendasContexto();

        //Construtor
        public Form1()
        {
            InitializeComponent();
            
            
        }

        //Métodos
        void CarregarDados(string filtro = "")
        {
            var listaDeVenda = vendasContexto.vendas.ToList();
            switch (filtro)
            {
                case "Id":
                    //Pesquisar por Id                    
                    dataGridView1.DataSource = listaDeVenda
                        .Where(v => v.Id == int.Parse(textBox1.Text))
                        .ToList();
                    break;
                case "DataCompra":
                    //Pesquisar pela data de compra
                    dataGridView1.DataSource = listaDeVenda
                        .Where(v => v.DataCompra
                        .ToString()
                        .Contains(textBox1.Text)).ToList();
                    break;
                case "Tipo":
                    //Pesquisar pelo tipo
                    dataGridView1.DataSource = listaDeVenda.Where(v =>
                    v.Tipo.Contains(textBox1.Text))
                        .ToList();
                    break;
                case "Marca":
                    //Pesquisar por marca.
                    dataGridView1.DataSource = listaDeVenda.Where(v =>
                    v.Marca.Contains(textBox1.Text))
                        .ToList();
                    break;
                default:
                    dataGridView1.DataSource = listaDeVenda;
                    break;
            }
        }

        //Eventos
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IsNullOrEmpty())
            {
                CarregarDados();
            }
            else if (radioButton1.Checked)
            {
                CarregarDados("Id");
            }
            else if (radioButton2.Checked)
            {
                CarregarDados("DataCompra");
            }
            else if (radioButton3.Checked)
            {
                CarregarDados("Tipo");
            }
            else if (radioButton4.Checked)
            {
                CarregarDados("Marca");
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var linhaselecionada = dataGridView1.SelectedRows[0];
           
            textBox2.Text = linhaselecionada.Cells["Id"].Value.ToString();
            textBox3.Text = linhaselecionada.Cells["DataCompra"].Value.ToString();
            textBox4.Text = linhaselecionada.Cells["Tipo"].Value.ToString();
            textBox5.Text = linhaselecionada.Cells["Marca"].Value.ToString();
            textBox6.Text = linhaselecionada.Cells["Faturamento"].Value.ToString();
            textBox7.Text = linhaselecionada.Cells["Lucro"].Value.ToString();
            tabControl1.SelectedTab = tabPage2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
            textBox6.ReadOnly = false;
            textBox7.ReadOnly = false;
        }
    }
}
