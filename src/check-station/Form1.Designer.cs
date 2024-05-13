namespace check_station
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
            txtSenha = new TextBox();
            cbxUsuario = new ComboBox();
            btnEntrar = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 14F);
            txtSenha.Location = new Point(49, 479);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(476, 45);
            txtSenha.TabIndex = 0;
            txtSenha.KeyDown += txtSenha_KeyDown;
            // 
            // cbxUsuario
            // 
            cbxUsuario.Font = new Font("Segoe UI", 14F);
            cbxUsuario.FormattingEnabled = true;
            cbxUsuario.Location = new Point(49, 371);
            cbxUsuario.Name = "cbxUsuario";
            cbxUsuario.Size = new Size(476, 46);
            cbxUsuario.TabIndex = 1;
            cbxUsuario.Text = "Selecione";
            cbxUsuario.SelectedValueChanged += cbxUsuario_SelectedValueChanged;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(368, 540);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(157, 55);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Visible = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(49, 325);
            label1.Name = "label1";
            label1.Size = new Size(94, 32);
            label1.TabIndex = 3;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(49, 444);
            label2.Name = "label2";
            label2.Size = new Size(80, 32);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1049, 675);
            panel1.TabIndex = 5;
            panel1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 675);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEntrar);
            Controls.Add(cbxUsuario);
            Controls.Add(txtSenha);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSenha;
        private ComboBox cbxUsuario;
        private Button btnEntrar;
        private Label label1;
        private Label label2;
        private Panel panel1;
    }
}
