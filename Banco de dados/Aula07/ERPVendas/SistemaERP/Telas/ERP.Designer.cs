namespace SistemaERP.Telas
{
    partial class ERP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            perfilToolStripMenuItem = new ToolStripMenuItem();
            vendasToolStripMenuItem = new ToolStripMenuItem();
            criarPedidoDeVendasToolStripMenuItem = new ToolStripMenuItem();
            consultaDePedidoDeVendasToolStripMenuItem = new ToolStripMenuItem();
            aprovaçãoDePedidoDeVendasToolStripMenuItem = new ToolStripMenuItem();
            relátorioDeVendasToolStripMenuItem = new ToolStripMenuItem();
            editarPedidoDeVendasToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            aprovaçãoDeUsuárioToolStripMenuItem = new ToolStripMenuItem();
            editarUsuárioToolStripMenuItem = new ToolStripMenuItem();
            consultaUsuárioToolStripMenuItem = new ToolStripMenuItem();
            criarUsuárioToolStripMenuItem = new ToolStripMenuItem();
            excluirUsuárioToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, vendasToolStripMenuItem, usuáriosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(907, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem, toolStripSeparator1, perfilToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(90, 29);
            toolStripMenuItem1.Text = "Sistema";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(152, 34);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(149, 6);
            // 
            // perfilToolStripMenuItem
            // 
            perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            perfilToolStripMenuItem.Size = new Size(152, 34);
            perfilToolStripMenuItem.Text = "Perfil";
            // 
            // vendasToolStripMenuItem
            // 
            vendasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { criarPedidoDeVendasToolStripMenuItem, consultaDePedidoDeVendasToolStripMenuItem, aprovaçãoDePedidoDeVendasToolStripMenuItem, relátorioDeVendasToolStripMenuItem, editarPedidoDeVendasToolStripMenuItem });
            vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            vendasToolStripMenuItem.Size = new Size(85, 29);
            vendasToolStripMenuItem.Text = "Vendas";
            // 
            // criarPedidoDeVendasToolStripMenuItem
            // 
            criarPedidoDeVendasToolStripMenuItem.Name = "criarPedidoDeVendasToolStripMenuItem";
            criarPedidoDeVendasToolStripMenuItem.Size = new Size(373, 34);
            criarPedidoDeVendasToolStripMenuItem.Text = "Criar pedido de vendas";
            // 
            // consultaDePedidoDeVendasToolStripMenuItem
            // 
            consultaDePedidoDeVendasToolStripMenuItem.Name = "consultaDePedidoDeVendasToolStripMenuItem";
            consultaDePedidoDeVendasToolStripMenuItem.Size = new Size(373, 34);
            consultaDePedidoDeVendasToolStripMenuItem.Text = "Consulta de pedido de vendas";
            // 
            // aprovaçãoDePedidoDeVendasToolStripMenuItem
            // 
            aprovaçãoDePedidoDeVendasToolStripMenuItem.Name = "aprovaçãoDePedidoDeVendasToolStripMenuItem";
            aprovaçãoDePedidoDeVendasToolStripMenuItem.Size = new Size(373, 34);
            aprovaçãoDePedidoDeVendasToolStripMenuItem.Text = "Aprovação de pedido de vendas";
            // 
            // relátorioDeVendasToolStripMenuItem
            // 
            relátorioDeVendasToolStripMenuItem.Name = "relátorioDeVendasToolStripMenuItem";
            relátorioDeVendasToolStripMenuItem.Size = new Size(373, 34);
            relátorioDeVendasToolStripMenuItem.Text = "Relátorio de vendas";
            relátorioDeVendasToolStripMenuItem.Click += relátorioDeVendasToolStripMenuItem_Click;
            // 
            // editarPedidoDeVendasToolStripMenuItem
            // 
            editarPedidoDeVendasToolStripMenuItem.Name = "editarPedidoDeVendasToolStripMenuItem";
            editarPedidoDeVendasToolStripMenuItem.Size = new Size(373, 34);
            editarPedidoDeVendasToolStripMenuItem.Text = "Editar pedido de vendas";
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aprovaçãoDeUsuárioToolStripMenuItem, editarUsuárioToolStripMenuItem, consultaUsuárioToolStripMenuItem, criarUsuárioToolStripMenuItem, excluirUsuárioToolStripMenuItem });
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(96, 29);
            usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // aprovaçãoDeUsuárioToolStripMenuItem
            // 
            aprovaçãoDeUsuárioToolStripMenuItem.Name = "aprovaçãoDeUsuárioToolStripMenuItem";
            aprovaçãoDeUsuárioToolStripMenuItem.Size = new Size(288, 34);
            aprovaçãoDeUsuárioToolStripMenuItem.Text = "Aprovação de usuário";
            aprovaçãoDeUsuárioToolStripMenuItem.Click += aprovaçãoDeUsuárioToolStripMenuItem_Click;
            // 
            // editarUsuárioToolStripMenuItem
            // 
            editarUsuárioToolStripMenuItem.Name = "editarUsuárioToolStripMenuItem";
            editarUsuárioToolStripMenuItem.Size = new Size(288, 34);
            editarUsuárioToolStripMenuItem.Text = "Editar usuário";
            // 
            // consultaUsuárioToolStripMenuItem
            // 
            consultaUsuárioToolStripMenuItem.Name = "consultaUsuárioToolStripMenuItem";
            consultaUsuárioToolStripMenuItem.Size = new Size(288, 34);
            consultaUsuárioToolStripMenuItem.Text = "Consulta usuário";
            // 
            // criarUsuárioToolStripMenuItem
            // 
            criarUsuárioToolStripMenuItem.Name = "criarUsuárioToolStripMenuItem";
            criarUsuárioToolStripMenuItem.Size = new Size(288, 34);
            criarUsuárioToolStripMenuItem.Text = "Criar usuário";
            // 
            // excluirUsuárioToolStripMenuItem
            // 
            excluirUsuárioToolStripMenuItem.Name = "excluirUsuárioToolStripMenuItem";
            excluirUsuárioToolStripMenuItem.Size = new Size(288, 34);
            excluirUsuárioToolStripMenuItem.Text = "Excluir usuário";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Clodoaldo;
            pictureBox1.Location = new Point(69, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(722, 401);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // reportViewer1
            // 
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(396, 246);
            reportViewer1.TabIndex = 0;
            // 
            // ERP
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(907, 594);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ERP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ERP Vendas";
            FormClosed += ERP_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem perfilToolStripMenuItem;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private ToolStripMenuItem consultaDePedidoDeVendasToolStripMenuItem;
        private ToolStripMenuItem aprovaçãoDePedidoDeVendasToolStripMenuItem;
        private ToolStripMenuItem relátorioDeVendasToolStripMenuItem;
        private ToolStripMenuItem editarPedidoDeVendasToolStripMenuItem;
        private ToolStripMenuItem criarPedidoDeVendasToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem aprovaçãoDeUsuárioToolStripMenuItem;
        private ToolStripMenuItem editarUsuárioToolStripMenuItem;
        private ToolStripMenuItem consultaUsuárioToolStripMenuItem;
        private ToolStripMenuItem criarUsuárioToolStripMenuItem;
        private ToolStripMenuItem excluirUsuárioToolStripMenuItem;
        private PictureBox pictureBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}