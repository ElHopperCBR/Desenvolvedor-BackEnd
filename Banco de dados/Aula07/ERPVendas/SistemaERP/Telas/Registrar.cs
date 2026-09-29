using SistemaERP.Classes.Contextos;
using SistemaERP.Classes.Entidades;
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
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void Registrar_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Botão de fechar
            TelaLogin.AbrirTela();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string sobrenome = textBox2.Text;
            long cpf = long.Parse(textBox3.Text);
            DateTime data = DateTime.SpecifyKind(monthCalendar1.SelectionStart, DateTimeKind.Utc);


            MessageBox.Show($"Nome = {nome}" +
                $"\nSobrenome = {sobrenome}" +
                $"\nCPF = {cpf}" +
                $"\nData = {data}" );
            string nomecompleto = nome + " " + sobrenome;
            Pessoa usuario = new Pessoa(nomecompleto,cpf,data,0);
            ContextoPessoa pessoa = new ContextoPessoa();
            pessoa.Pessoas.Add(usuario);
            pessoa.SaveChanges();
        }
    }
}
