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
    }
}
