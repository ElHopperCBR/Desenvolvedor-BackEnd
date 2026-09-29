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
    public partial class Senha : Form
    {
        public Senha()
        {
            InitializeComponent();
        }

        private void Senha_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Botão de fechar da tela
            TelaLogin.AbrirTela();
        }
    }
}
