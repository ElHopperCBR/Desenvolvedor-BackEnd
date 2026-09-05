namespace CasasBahia2
{
    partial class Form2
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            textBox4 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            tabPage3 = new TabPage();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            button3 = new Button();
            textBox5 = new TextBox();
            label5 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(21, 23);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(767, 415);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightGray;
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(759, 377);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastrar item";
            // 
            // button1
            // 
            button1.Location = new Point(239, 305);
            button1.Name = "button1";
            button1.Size = new Size(382, 34);
            button1.TabIndex = 6;
            button1.Text = "Criar item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 231);
            label3.Name = "label3";
            label3.Size = new Size(163, 25);
            label3.TabIndex = 5;
            label3.Text = "Preço do produto: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 168);
            label2.Name = "label2";
            label2.Size = new Size(205, 25);
            label2.TabIndex = 4;
            label2.Text = "Quantidade de produto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 92);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 3;
            label1.Text = "Nome do produto:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(239, 228);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(382, 31);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(239, 165);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(382, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(239, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(382, 31);
            textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.PapayaWhip;
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(button2);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(759, 377);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consultar item";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(170, 72);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(390, 31);
            textBox4.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 77);
            label4.Name = "label4";
            label4.Size = new Size(136, 25);
            label4.TabIndex = 1;
            label4.Text = "Digite o código";
            // 
            // button2
            // 
            button2.Location = new Point(580, 72);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 0;
            button2.Text = "Pesquisar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.LemonChiffon;
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(textBox6);
            tabPage3.Controls.Add(textBox7);
            tabPage3.Controls.Add(textBox8);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(textBox5);
            tabPage3.Controls.Add(label5);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(759, 377);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Editar item";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(95, 283);
            label6.Name = "label6";
            label6.Size = new Size(163, 25);
            label6.TabIndex = 11;
            label6.Text = "Preço do produto: ";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 220);
            label7.Name = "label7";
            label7.Size = new Size(205, 25);
            label7.TabIndex = 10;
            label7.Text = "Quantidade de produto:";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(95, 144);
            label8.Name = "label8";
            label8.Size = new Size(163, 25);
            label8.TabIndex = 9;
            label8.Text = "Nome do produto:";
            label8.Visible = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(264, 280);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(382, 31);
            textBox6.TabIndex = 8;
            textBox6.Visible = false;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(264, 217);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(382, 31);
            textBox7.TabIndex = 7;
            textBox7.Visible = false;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(264, 141);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(382, 31);
            textBox8.TabIndex = 6;
            textBox8.Visible = false;
            // 
            // button3
            // 
            button3.Location = new Point(604, 77);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 5;
            button3.Text = "Pesquisar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(193, 77);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(390, 31);
            textBox5.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 82);
            label5.Name = "label5";
            label5.Size = new Size(136, 25);
            label5.TabIndex = 3;
            label5.Text = "Digite o código";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form2";
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private Label label4;
        private Button button2;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Button button3;
        private TextBox textBox5;
        private Label label5;
    }
}