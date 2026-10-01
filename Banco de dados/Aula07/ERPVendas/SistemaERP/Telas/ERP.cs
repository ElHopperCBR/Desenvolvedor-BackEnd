using Microsoft.Reporting.WinForms;
using SistemaERP.Classes.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaERP.Telas
{
    public partial class ERP : Form
    {
        public ERP()
        {
            InitializeComponent();
        }

        private void ERP_FormClosed(object sender, FormClosedEventArgs e)
        {
            TelaLogin.AbrirTela();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            TelaLogin.AbrirTela();
        }

        private void aprovaçãoDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Aprovacao tela = new Aprovacao();
            tela.Show();
        }

        private void relátorioDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CarregarRelatorio();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Não foi possivel carregar o relatório: Erro -> {ex.Message}");
            }
        }

        private void CarregarRelatorio()
        {
            Hide();
            RelatorioVendas relatorio = new RelatorioVendas();
            relatorio.Show();
        }
    }
}
