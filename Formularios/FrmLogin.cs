using System;
using System.Windows.Forms;

namespace ControleEstoque.Formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            // Foco inicial no usuário
            this.ActiveControl = txtUsuario;
        }

        private bool IsLoginValido()
        {
            return txtUsuario.Text.ToUpper() == "ADMIN"
                && txtSenha.Text.ToUpper() == "ADMIN";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsLoginValido())
            {
                using (var frmSetup = new FrmSetup())
                {
                    this.Hide();
                    frmSetup.ShowDialog();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Usuário ou senha inválidos!",
                    "Erro de Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                txtSenha.Clear();
                txtSenha.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // mata o Enter no TextBox
                btnLogin.PerformClick(); // simula o clique no botão de login
            }
        }
    }
}
