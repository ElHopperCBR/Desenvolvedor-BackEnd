namespace TelaBanco
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            textBox2 = new TextBox();
            button2 = new Button();
            label4 = new Label();
            label3 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            button4 = new Button();
            button3 = new Button();
            dataGridView2 = new DataGridView();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 46);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 402);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 364);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Listar contas";
            toolTip1.SetToolTip(tabPage1, "Lista todas as contas existente no banco de dados do servidor");
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.refrescar;
            button1.Location = new Point(650, 8);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            toolTip1.SetToolTip(button1, "Atualiza os dados da tabela de contas");
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(756, 310);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(radioButton2);
            tabPage2.Controls.Add(radioButton1);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 364);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Criar conta";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(311, 261);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 9;
            textBox2.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(530, 308);
            button2.Name = "button2";
            button2.Size = new Size(233, 51);
            button2.TabIndex = 8;
            button2.Text = "Criar conta";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 264);
            label4.Name = "label4";
            label4.Size = new Size(238, 25);
            label4.TabIndex = 6;
            label4.Text = "Valor do depósito inicial:  R$";
            label4.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 197);
            label3.Name = "label3";
            label3.Size = new Size(261, 25);
            label3.TabIndex = 5;
            label3.Text = "Deseja realizar depósito inicial? ";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(423, 195);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(70, 29);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Não";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(327, 195);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(67, 29);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Sim";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(285, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(377, 31);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 118);
            label2.Name = "label2";
            label2.Size = new Size(143, 25);
            label2.TabIndex = 1;
            label2.Text = "Titular da conta: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(202, 19);
            label1.Name = "label1";
            label1.Size = new Size(349, 50);
            label1.TabIndex = 0;
            label1.Text = "Dados da conta";
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(768, 364);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Editar conta";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(button3);
            tabPage4.Controls.Add(dataGridView2);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(768, 364);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Excluir conta";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Image = Properties.Resources.refrescar;
            button4.Location = new Point(650, 16);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 2;
            toolTip1.SetToolTip(button4, "Atualiza os dados da tabela de contas");
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(201, 301);
            button3.Name = "button3";
            button3.Size = new Size(379, 53);
            button3.TabIndex = 1;
            button3.Text = "Deletar dado";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 67);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(756, 228);
            dataGridView2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private ToolTip toolTip1;
        private DataGridView dataGridView1;
        private Button button1;
        private ToolTip toolTip2;
        private Label label4;
        private Label label3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button button2;
        private TextBox textBox2;
        private Button button4;
        private Button button3;
        private DataGridView dataGridView2;
    }
}
