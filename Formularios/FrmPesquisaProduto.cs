using ControleEstoque.Data;
using ControleEstoque.Models;

namespace ControleEstoque.Formularios
{
    public partial class FrmPesquisaProduto : Form
    {
        public Produto ProdutoSelecionado { get; private set; }

        public FrmPesquisaProduto()
        {
            InitializeComponent();
            ConfigurarGrid();
            CarregarProdutos();
        }

        private void ConfigurarGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nome",
                HeaderText = "Nome"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EstoqueAtual",
                HeaderText = "Estoque"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PrecoVenda",
                HeaderText = "Preço Venda",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            // eventos importantes
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.KeyDown += dataGridView1_KeyDown;
        }

        private void CarregarProdutos(string filtro = null)
        {
            var db = new DatabaseContext();
            dataGridView1.DataSource = db.GetProdutos(filtro);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var texto = txtProduto.Text?.Trim();
            CarregarProdutos(texto);
        }

        private void txtProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnPesquisar.PerformClick();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            SelecionarProduto();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionarProduto();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelecionarProduto();
            }
        }

        private void SelecionarProduto()
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            ProdutoSelecionado =
                dataGridView1.SelectedRows[0].DataBoundItem as Produto;

            if (ProdutoSelecionado == null)
                return;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
