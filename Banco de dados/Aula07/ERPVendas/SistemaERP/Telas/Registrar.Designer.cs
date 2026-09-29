namespace SistemaERP.Telas
{
    partial class Registrar
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            monthCalendar1 = new MonthCalendar();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(113, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(537, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(103, 253);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(230, 31);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 95);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 4;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 253);
            label2.Name = "label2";
            label2.Size = new Size(42, 25);
            label2.TabIndex = 5;
            label2.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(370, 92);
            label3.Name = "label3";
            label3.Size = new Size(161, 25);
            label3.TabIndex = 6;
            label3.Text = "Ultimo sobrenome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(537, 219);
            label4.Name = "label4";
            label4.Size = new Size(170, 25);
            label4.TabIndex = 7;
            label4.Text = "Data de nascimento";
            // 
            // button1
            // 
            button1.Location = new Point(168, 424);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(240, 9);
            label5.Name = "label5";
            label5.Size = new Size(366, 54);
            label5.TabIndex = 9;
            label5.Text = "Registro de usuario";
            // 
            // monthCalendar1
            // 
            monthCalendar1.ContextMenuStrip = contextMenuStrip1;
            monthCalendar1.Location = new Point(472, 253);
            monthCalendar1.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Registrar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 533);
            Controls.Add(monthCalendar1);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Registrar";
            Text = "Cadastro de usuario";
            FormClosed += Registrar_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
        private MonthCalendar monthCalendar1;
        private ContextMenuStrip contextMenuStrip1;
    }
}