namespace SenacAlimentacao
{
    partial class FrmLogin
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
            panel1 = new Panel();
            panel2 = new Panel();
            btnEntrar = new Button();
            textBox1 = new TextBox();
            txtLogin = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEntrar);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(txtLogin);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(270, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(530, 450);
            panel2.TabIndex = 1;
            // 
            // btnEntrar
            // 
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.White;
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 16F);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(103, 290);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(324, 58);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(192, 64, 0);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(103, 209);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(424, 43);
            textBox1.TabIndex = 0;
            textBox1.Text = "SENHA";
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(192, 64, 0);
            txtLogin.BorderStyle = BorderStyle.None;
            txtLogin.Font = new Font("Segoe UI", 16F);
            txtLogin.ForeColor = Color.White;
            txtLogin.Location = new Point(103, 112);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(424, 43);
            txtLogin.TabIndex = 0;
            txtLogin.Text = "USUÁRIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(103, 229);
            label2.Name = "label2";
            label2.Size = new Size(324, 32);
            label2.TabIndex = 1;
            label2.Text = "_______________________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(103, 130);
            label1.Name = "label1";
            label1.Size = new Size(324, 32);
            label1.TabIndex = 1;
            label1.Text = "_______________________________";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 64, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtLogin;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button btnEntrar;
    }
}
