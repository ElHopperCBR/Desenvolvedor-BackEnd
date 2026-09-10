using VendasSenai.Classes.Contextos;

namespace Vendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            VendasContexto vendas1 = new VendasContexto();
            InitializeComponent();
            CarregarDados();
            
        }

        void CarregarDados()
        {
            try
            {
                VendasContexto vendasContexto = new VendasContexto();                
                var listaDeVenda = vendasContexto.vendas.ToList();
                dataGridView1.DataSource = listaDeVenda;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

      
    }
}
