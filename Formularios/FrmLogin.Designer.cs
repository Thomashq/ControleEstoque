namespace ControleEstoque.Formularios
{
    partial class FrmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            grpLogin = new GroupBox();
            btnCancelar = new Button();
            btnLogin = new Button();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            lblSenha = new Label();
            lblUsuario = new Label();
            grpLogin.SuspendLayout();
            SuspendLayout();
            // 
            // grpLogin
            // 
            grpLogin.Controls.Add(btnCancelar);
            grpLogin.Controls.Add(btnLogin);
            grpLogin.Controls.Add(txtUsuario);
            grpLogin.Controls.Add(txtSenha);
            grpLogin.Controls.Add(lblSenha);
            grpLogin.Controls.Add(lblUsuario);
            grpLogin.Location = new Point(6, 4);
            grpLogin.Name = "grpLogin";
            grpLogin.Size = new Size(492, 256);
            grpLogin.TabIndex = 0;
            grpLogin.TabStop = false;
            grpLogin.Text = "Login";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(268, 172);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(157, 172);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(151, 59);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(217, 27);
            txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(151, 106);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(217, 27);
            txtSenha.TabIndex = 3;
            txtSenha.KeyDown += txtSenha_KeyDown;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(89, 110);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(52, 20);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(85, 63);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuário:";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 268);
            Controls.Add(grpLogin);
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            grpLogin.ResumeLayout(false);
            grpLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpLogin;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label lblSenha;
        private Label lblUsuario;
        private Button btnCancelar;
        private Button btnLogin;
    }
}
