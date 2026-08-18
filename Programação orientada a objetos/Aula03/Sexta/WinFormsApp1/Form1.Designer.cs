namespace WinFormsApp1
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(83, 305);
            button1.Name = "button1";
            button1.Size = new Size(191, 66);
            button1.TabIndex = 0;
            button1.Text = "Logar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(105, 52);
            label1.Name = "label1";
            label1.Size = new Size(157, 54);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(105, 166);
            label2.Name = "label2";
            label2.Size = new Size(131, 54);
            label2.TabIndex = 2;
            label2.Text = "Senha";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(43, 223);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(278, 31);
            textBox2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 444);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
