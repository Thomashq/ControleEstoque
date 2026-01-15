using ControleEstoque.Data;
using ControleEstoque.Models;

namespace ControleEstoque.Formularios
{
    public partial class FrmSetup : Form
    {
        private Produto _produtoSelecionado;
        private Movimentacao _movSelecionada;
        private int _produtoMovSelecionadoId = 0;

        public FrmSetup()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        #region ===== PRODUTOS =====

        private void ConfigurarFormulario()
        {
            // GRID PRODUTOS
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PrecoCompra",
                HeaderText = "Compra",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PrecoVenda",
                HeaderText = "Venda",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EstoqueAtual",
                HeaderText = "Estoque"
            });

            ConfigurarMovimentacoes();

            BloquearFormulario();
            BloquearFormularioMov();
            ConfigurarBalanco();
            CarregarProdutos();
            CarregarMovimentacoes();
        }

        private void CarregarProdutos(string filtroNome = null)
        {
            var db = new DatabaseContext();
            dataGridView1.DataSource = db.GetProdutos(filtroNome);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            _produtoSelecionado = dataGridView1.SelectedRows[0].DataBoundItem as Produto;
            if (_produtoSelecionado == null) return;

            txtNome.Text = _produtoSelecionado.Nome;
            txtDescr.Text = _produtoSelecionado.Descricao;
            txtValorCompra.Text = _produtoSelecionado.PrecoCompra.ToString("N2");
            txtValorVenda.Text = _produtoSelecionado.PrecoVenda.ToString("N2");

            txtQuantidade.Text = _produtoSelecionado.EstoqueAtual.ToString();
            txtQuantidade.Enabled = false;

            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _produtoSelecionado = null;
            dataGridView1.ClearSelection();

            LimparFormulario();
            DesbloquearFormulario(true);

            txtNome.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (_produtoSelecionado == null) return;
            DesbloquearFormulario(false);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!FormularioValido()) return;

            var db = new DatabaseContext();
            var produto = _produtoSelecionado ?? new Produto();

            produto.Nome = txtNome.Text;
            produto.Descricao = txtDescr.Text;
            produto.PrecoCompra = decimal.Parse(txtValorCompra.Text);
            produto.PrecoVenda = decimal.Parse(txtValorVenda.Text);

            if (_produtoSelecionado == null)
                produto.EstoqueAtual = decimal.Parse(txtQuantidade.Text);

            if (produto.DataCadastro == DateTime.MinValue)
                produto.DataCadastro = DateTime.Now;

            db.SaveProduto(produto);

            LimparFormulario();
            BloquearFormulario();
            CarregarProdutos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_produtoSelecionado == null) return;

            var db = new DatabaseContext();
            db.DeleteProduto(_produtoSelecionado);

            LimparFormulario();
            BloquearFormulario();
            CarregarProdutos();
        }

        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            CarregarProdutos(txtPesqProduto.Text.Trim());
        }

        private void txtPesqProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnPesquisarProduto.PerformClick();
            }
        }
        private void btnEditarMov_Click(object sender, EventArgs e)
        {
            if (_movSelecionada == null)
                return;

            DesbloquearFormularioMov();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CarregarMovimentacoes();
        }

        #endregion

        #region ===== MOVIMENTAÇÕES =====

        private void ConfigurarMovimentacoes()
        {
            cmbTipoMov.Items.Clear();
            cmbTipoMov.Items.Add("Entrada");
            cmbTipoMov.Items.Add("Saída");
            cmbTipoMov.SelectedIndex = 0;

            dtMov.Value = DateTime.Today;
        }

        private void CarregarMovimentacoes()
        {
            var db = new DatabaseContext();

            DateTime data = dtMov.Value.Date;
            string filtroProduto = txtProdutoMov.Text?.Trim();

            dgMovimentacao.DataSource = db.GetMovimentacoes(data, filtroProduto);
        }

        private void dgMovimentacao_SelectionChanged(object sender, EventArgs e)
        {
            if (dgMovimentacao.SelectedRows.Count == 0) return;

            _movSelecionada = dgMovimentacao.SelectedRows[0].DataBoundItem as Movimentacao;
            if (_movSelecionada == null) return;

            cmbTipoMov.SelectedItem = _movSelecionada.Tipo;
            txtQuantMov.Text = _movSelecionada.Quantidade.ToString();
            txtValorUnit.Text = _movSelecionada.ValorUnitario.ToString("N2");
            txtObservacaoMov.Text = _movSelecionada.Observacao;

            _produtoMovSelecionadoId = _movSelecionada.ProdutoId;
            txtProdutoModal.Text = _movSelecionada.NomeProduto;

            DesbloquearFormularioMov();
            btnExcluirMov.Enabled = true;
        }

        private void btnPesquisarMov_Click(object sender, EventArgs e)
        {
            CarregarMovimentacoes();
        }

        private void btnNovaMov_Click(object sender, EventArgs e)
        {
            _movSelecionada = null;
            _produtoMovSelecionadoId = 0;

            LimparFormularioMov();
            DesbloquearFormularioMov();

            txtProdutoModal.Clear();
            cmbTipoMov.SelectedIndex = 0;
        }

        private void btnSalvarMov_Click(object sender, EventArgs e)
        {
            if (_produtoMovSelecionadoId == 0) return;

            var db = new DatabaseContext();
            var mov = _movSelecionada ?? new Movimentacao();

            mov.ProdutoId = _produtoMovSelecionadoId;
            mov.Tipo = cmbTipoMov.SelectedItem.ToString();
            mov.Quantidade = decimal.Parse(txtQuantMov.Text);
            mov.ValorUnitario = decimal.Parse(txtValorUnit.Text);
            mov.Observacao = txtObservacaoMov.Text;
            mov.DataMovimentacao = dtMov.Value.Date;
            mov.HoraMovimentacao = DateTime.Now.TimeOfDay;

            db.SaveMovimentacao(mov);

            LimparFormularioMov();
            BloquearFormularioMov();
            CarregarMovimentacoes();
        }

        private void btnExcluirMov_Click(object sender, EventArgs e)
        {
            if (_movSelecionada == null) return;

            var db = new DatabaseContext();
            db.DeleteMovimentacao(_movSelecionada);

            LimparFormularioMov();
            BloquearFormularioMov();
            CarregarMovimentacoes();
        }

        private void btnPesqProdMov_Click(object sender, EventArgs e)
        {
            using var frm = new FrmPesquisaProduto();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _produtoMovSelecionadoId = frm.ProdutoSelecionado.Id;
                txtProdutoModal.Text = frm.ProdutoSelecionado.Nome;
            }
        }

        #endregion

        #region ===== UTIL =====

        private void BloquearFormulario()
        {
            txtNome.Enabled = false;
            txtDescr.Enabled = false;
            txtValorCompra.Enabled = false;
            txtValorVenda.Enabled = false;
            txtQuantidade.Enabled = false;

            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void DesbloquearFormulario(bool novo)
        {
            txtNome.Enabled = true;
            txtDescr.Enabled = true;
            txtValorCompra.Enabled = true;
            txtValorVenda.Enabled = true;
            txtQuantidade.Enabled = novo;

            btnSalvar.Enabled = true;
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtDescr.Clear();
            txtValorCompra.Text = "0,00";
            txtValorVenda.Text = "0,00";
            txtQuantidade.Text = "0";
        }

        private void LimparFormularioMov()
        {
            txtQuantMov.Text = "0";
            txtValorUnit.Text = "0,00";
            txtObservacaoMov.Clear();
        }

        private void BloquearFormularioMov()
        {
            cmbTipoMov.Enabled = false;
            txtProdutoModal.Enabled = false;
            txtQuantMov.Enabled = false;
            txtValorUnit.Enabled = false;
            txtObservacaoMov.Enabled = false;

            btnSalvarMov.Enabled = false;
            btnExcluirMov.Enabled = false;
        }

        private void DesbloquearFormularioMov()
        {
            cmbTipoMov.Enabled = true;
            txtQuantMov.Enabled = true;
            txtValorUnit.Enabled = true;
            txtObservacaoMov.Enabled = true;

            btnSalvarMov.Enabled = true;
        }

        private bool FormularioValido()
        {
            return !string.IsNullOrWhiteSpace(txtNome.Text);
        }
        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            // permite apenas números e backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        #endregion

        #region  BALANCO
        private void ConfigurarBalanco()
        {
            rdHoje.Checked = true;

            dtpInicial.Enabled = false;
            dtpFinal.Enabled = false;

            dvgMovimentacoesBalanco.AutoGenerateColumns = false;
            dvgMovimentacoesBalanco.ReadOnly = true;
            dvgMovimentacoesBalanco.AllowUserToAddRows = false;
            dvgMovimentacoesBalanco.AllowUserToDeleteRows = false;
            dvgMovimentacoesBalanco.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgMovimentacoesBalanco.MultiSelect = false;

            ConfigurarColunasBalanco();
        }

        private void rdHoje_CheckedChanged(object sender, EventArgs e)
        {
            if (rdHoje.Checked)
            {
                dtpInicial.Enabled = false;
                dtpFinal.Enabled = false;
            }
        }

        private void rdPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPeriodo.Checked)
            {
                dtpInicial.Enabled = true;
                dtpFinal.Enabled = true;
            }
        }


        private void btnGerarBalanco_Click(object sender, EventArgs e)
        {
            DateTime inicio;
            DateTime fim;

            if (rdHoje.Checked)
            {
                inicio = DateTime.Today;
                fim = DateTime.Today.AddDays(1).AddTicks(-1);
            }
            else
            {
                inicio = dtpInicial.Value.Date;
                fim = dtpFinal.Value.Date.AddDays(1).AddTicks(-1);
            }

            CarregarBalanco(inicio, fim);
        }

        private void CarregarBalanco(DateTime inicio, DateTime fim)
        {
            var db = new DatabaseContext();
            var lista = db.GetMovimentacoesPorPeriodo(inicio, fim);

            dvgMovimentacoesBalanco.DataSource = lista;

            AtualizarResumoBalanco(lista);
        }

        private void AtualizarResumoBalanco(List<Movimentacao> lista)
        {
            var entradas = lista
                .Where(x => x.Tipo == "Entrada")
                .Sum(x => x.Quantidade);

            var saidas = lista
                .Where(x => x.Tipo == "Saída")
                .Sum(x => x.Quantidade);

            var valorTotal = lista.Sum(x => x.ValorTotal);

            lblEntradasValor.Text = entradas.ToString();
            lblSaidasValor.Text = saidas.ToString();
            lblSaldoValor.Text = (entradas - saidas).ToString();
            lblValorTotalValor.Text = valorTotal.ToString("C2");
        }

        private void ConfigurarColunasBalanco()
        {
            dvgMovimentacoesBalanco.Columns.Clear();

            dvgMovimentacoesBalanco.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataHoraMovimentacao",
                HeaderText = "Data/Hora",
                Width = 140
            });

            dvgMovimentacoesBalanco.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NomeProduto",
                HeaderText = "Produto",
                Width = 250
            });

            dvgMovimentacoesBalanco.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Tipo",
                HeaderText = "Tipo",
                Width = 80
            });

            dvgMovimentacoesBalanco.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantidade",
                HeaderText = "Qtd",
                Width = 60
            });

            dvgMovimentacoesBalanco.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ValorTotal",
                HeaderText = "Valor Total",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });
        }



        #endregion
    }
}

