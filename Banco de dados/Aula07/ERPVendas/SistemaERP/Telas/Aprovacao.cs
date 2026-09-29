using SistemaERP.Classes.Contextos;
using SistemaERP.Classes.Entidades;
using SistemaERP.Classes.Enumeracoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SistemaERP.Telas
{
    public partial class Aprovacao : Form
    {
        ContextoPessoa pessoa = new ContextoPessoa();
        public Aprovacao()
        {
            InitializeComponent();
        }

        private void Aprovacao_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;

            DateTime hoje = DateTime.Today;
            dataGridView1.DataSource = pessoa
                .Pessoas
                .Select(t =>
                new
                {
                    t.Id,
                    t.NomeDoUsuario,
                    t.CPF,
                    Data = hoje.Year - t.DataNascimento.Year,
                    Status = (StatusUsuario)(t.Status)
                })
                .ToList();
            dataGridView1.Columns[0].HeaderText = "N° do Usuário";
            dataGridView1.Columns[1].HeaderText = "Nome do usuário";
            dataGridView1.Columns[2].HeaderText = "CPF";
            dataGridView1.Columns[3].HeaderText = "Idade";
            dataGridView1.Columns[4].HeaderText = "Estado do usuário";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow linhaSelecionada = dataGridView1.SelectedRows[0];
            ContextoUsuario novoUsuario = new ContextoUsuario();
            string nome = linhaSelecionada.Cells["NomeDoUsuario"].Value.ToString();
            Random aleatorio = new Random();
            string senha = Convert.ToString(aleatorio.Next(1000, 5000));
            int regra;
            if (radioButton1.Checked)
            {
                regra = 0;
            }
            else
            {
                regra = 1;
            }
            
            MessageBox.Show($"Usuário cadastrado com Sucesso!" +
                $"\nNome = {nome}, Senha = {senha}, Regra = {regra}");

            var user = pessoa.Pessoas.FirstOrDefault();
            Usuario usuario = new Usuario(nome, senha, regra);
            novoUsuario.Add(usuario);
            novoUsuario.SaveChanges();
            
            
        }
    }
}
