namespace ControleEstoque.Formularios
{
    partial class FrmSetup
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tbFormSetup = new TabControl();
            tbProdutos = new TabPage();
            btnPesquisarProduto = new Button();
            txtPesqProduto = new TextBox();
            lblPesqProduto = new Label();
            grpProduto = new GroupBox();
            txtQuantidade = new ControleEstoque.Personalizados.TextBoxQuantidade();
            txtValorVenda = new ControleEstoque.Personalizados.TextBoxMoeda();
            txtValorCompra = new ControleEstoque.Personalizados.TextBoxMoeda();
            lblNome = new Label();
            txtNome = new TextBox();
            lblDescricao = new Label();
            txtDescr = new TextBox();
            lblPrecoCompra = new Label();
            lblPrecoVenda = new Label();
            lblQuantidade = new Label();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnNovo = new Button();
            btnEditar = new Button();
            dataGridView1 = new DataGridView();
            tbMovimentacao = new TabPage();
            grpMov = new GroupBox();
            txtValorUnit = new ControleEstoque.Personalizados.TextBoxMoeda();
            txtQuantMov = new ControleEstoque.Personalizados.TextBoxQuantidade();
            btnSalvarMov = new Button();
            btnExcluirMov = new Button();
            txtObservacaoMov = new TextBox();
            lblObservacaoMov = new Label();
            lblValorUnit = new Label();
            lblQuantMov = new Label();
            btnPesqProdMov = new Button();
            txtProdutoModal = new TextBox();
            lblProdutoMov = new Label();
            cmbTipoMov = new ComboBox();
            label2 = new Label();
            btnEditarMov = new Button();
            btnNovaMov = new Button();
            dgMovimentacao = new DataGridView();
            grpPeriodo = new GroupBox();
            lblPesqProdutoMov = new Button();
            txtProdutoMov = new TextBox();
            label1 = new Label();
            dtMov = new DateTimePicker();
            tbBalanco = new TabPage();
            btnCancelarCsv = new Button();
            btnExportarCsv = new Button();
            label5 = new Label();
            dvgMovimentacoesBalanco = new DataGridView();
            grpValorTotal = new GroupBox();
            lblValorTotalValor = new Label();
            grpSaldo = new GroupBox();
            lblSaldoValor = new Label();
            grpSaidas = new GroupBox();
            lblSaidasValor = new Label();
            grpEntradas = new GroupBox();
            lblEntradasValor = new Label();
            label4 = new Label();
            grpFiltros = new GroupBox();
            rdPeriodo = new RadioButton();
            rdHoje = new RadioButton();
            button1 = new Button();
            label3 = new Label();
            lblInicio = new Label();
            dtpFinal = new DateTimePicker();
            dtpInicial = new DateTimePicker();
            lblTipo = new Label();
            tbFormSetup.SuspendLayout();
            tbProdutos.SuspendLayout();
            grpProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tbMovimentacao.SuspendLayout();
            grpMov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgMovimentacao).BeginInit();
            grpPeriodo.SuspendLayout();
            tbBalanco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgMovimentacoesBalanco).BeginInit();
            grpValorTotal.SuspendLayout();
            grpSaldo.SuspendLayout();
            grpSaidas.SuspendLayout();
            grpEntradas.SuspendLayout();
            grpFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // tbFormSetup
            // 
            tbFormSetup.Controls.Add(tbProdutos);
            tbFormSetup.Controls.Add(tbMovimentacao);
            tbFormSetup.Controls.Add(tbBalanco);
            tbFormSetup.Dock = DockStyle.Fill;
            tbFormSetup.Location = new Point(0, 0);
            tbFormSetup.Name = "tbFormSetup";
            tbFormSetup.SelectedIndex = 0;
            tbFormSetup.Size = new Size(1146, 816);
            tbFormSetup.TabIndex = 0;
            // 
            // tbProdutos
            // 
            tbProdutos.Controls.Add(btnPesquisarProduto);
            tbProdutos.Controls.Add(txtPesqProduto);
            tbProdutos.Controls.Add(lblPesqProduto);
            tbProdutos.Controls.Add(grpProduto);
            tbProdutos.Controls.Add(btnNovo);
            tbProdutos.Controls.Add(btnEditar);
            tbProdutos.Controls.Add(dataGridView1);
            tbProdutos.Location = new Point(4, 24);
            tbProdutos.Name = "tbProdutos";
            tbProdutos.Size = new Size(1138, 788);
            tbProdutos.TabIndex = 0;
            tbProdutos.Text = "Produtos";
            // 
            // btnPesquisarProduto
            // 
            btnPesquisarProduto.Location = new Point(311, 39);
            btnPesquisarProduto.Name = "btnPesquisarProduto";
            btnPesquisarProduto.Size = new Size(94, 29);
            btnPesquisarProduto.TabIndex = 6;
            btnPesquisarProduto.Text = "Buscar";
            btnPesquisarProduto.UseVisualStyleBackColor = true;
            btnPesquisarProduto.Click += btnPesquisarProduto_Click;
            // 
            // txtPesqProduto
            // 
            txtPesqProduto.Location = new Point(18, 40);
            txtPesqProduto.Name = "txtPesqProduto";
            txtPesqProduto.Size = new Size(254, 23);
            txtPesqProduto.TabIndex = 1;
            txtPesqProduto.KeyDown += txtPesqProduto_KeyDown;
            // 
            // lblPesqProduto
            // 
            lblPesqProduto.AutoSize = true;
            lblPesqProduto.Location = new Point(16, 17);
            lblPesqProduto.Name = "lblPesqProduto";
            lblPesqProduto.Size = new Size(103, 15);
            lblPesqProduto.TabIndex = 4;
            lblPesqProduto.Text = "Pesquisar Produto";
            // 
            // grpProduto
            // 
            grpProduto.Controls.Add(txtQuantidade);
            grpProduto.Controls.Add(txtValorVenda);
            grpProduto.Controls.Add(txtValorCompra);
            grpProduto.Controls.Add(lblNome);
            grpProduto.Controls.Add(txtNome);
            grpProduto.Controls.Add(lblDescricao);
            grpProduto.Controls.Add(txtDescr);
            grpProduto.Controls.Add(lblPrecoCompra);
            grpProduto.Controls.Add(lblPrecoVenda);
            grpProduto.Controls.Add(lblQuantidade);
            grpProduto.Controls.Add(btnSalvar);
            grpProduto.Controls.Add(btnExcluir);
            grpProduto.Location = new Point(8, 467);
            grpProduto.Name = "grpProduto";
            grpProduto.Size = new Size(710, 313);
            grpProduto.TabIndex = 0;
            grpProduto.TabStop = false;
            grpProduto.Text = "Produto";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(325, 194);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(120, 23);
            txtQuantidade.TabIndex = 5;
            txtQuantidade.Text = "0,000";
            txtQuantidade.TextAlign = HorizontalAlignment.Right;
            // 
            // txtValorVenda
            // 
            txtValorVenda.Location = new Point(325, 144);
            txtValorVenda.Name = "txtValorVenda";
            txtValorVenda.Size = new Size(120, 23);
            txtValorVenda.TabIndex = 4;
            txtValorVenda.Text = "0,00";
            txtValorVenda.TextAlign = HorizontalAlignment.Right;
            // 
            // txtValorCompra
            // 
            txtValorCompra.Location = new Point(325, 90);
            txtValorCompra.Name = "txtValorCompra";
            txtValorCompra.Size = new Size(120, 23);
            txtValorCompra.TabIndex = 3;
            txtValorCompra.Text = "0,00";
            txtValorCompra.TextAlign = HorizontalAlignment.Right;
            // 
            // lblNome
            // 
            lblNome.Location = new Point(35, 57);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(100, 23);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(35, 83);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(248, 23);
            txtNome.TabIndex = 2;
            // 
            // lblDescricao
            // 
            lblDescricao.Location = new Point(35, 130);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(100, 23);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descrição";
            // 
            // txtDescr
            // 
            txtDescr.Location = new Point(35, 156);
            txtDescr.Multiline = true;
            txtDescr.Name = "txtDescr";
            txtDescr.Size = new Size(248, 84);
            txtDescr.TabIndex = 3;
            // 
            // lblPrecoCompra
            // 
            lblPrecoCompra.Location = new Point(325, 70);
            lblPrecoCompra.Name = "lblPrecoCompra";
            lblPrecoCompra.Size = new Size(100, 23);
            lblPrecoCompra.TabIndex = 4;
            lblPrecoCompra.Text = "Preço Compra (R$)";
            // 
            // lblPrecoVenda
            // 
            lblPrecoVenda.Location = new Point(325, 124);
            lblPrecoVenda.Name = "lblPrecoVenda";
            lblPrecoVenda.Size = new Size(100, 23);
            lblPrecoVenda.TabIndex = 6;
            lblPrecoVenda.Text = "Preço Venda (R$)";
            // 
            // lblQuantidade
            // 
            lblQuantidade.Location = new Point(325, 175);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(100, 23);
            lblQuantidade.TabIndex = 8;
            lblQuantidade.Text = "Quantidade";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(568, 107);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(121, 42);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(569, 175);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(120, 42);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(869, 480);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(128, 29);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo Produto";
            btnNovo.Click += btnNovo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(1017, 480);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(0, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1135, 362);
            dataGridView1.TabIndex = 3;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // tbMovimentacao
            // 
            tbMovimentacao.Controls.Add(grpMov);
            tbMovimentacao.Controls.Add(btnEditarMov);
            tbMovimentacao.Controls.Add(btnNovaMov);
            tbMovimentacao.Controls.Add(dgMovimentacao);
            tbMovimentacao.Controls.Add(grpPeriodo);
            tbMovimentacao.Location = new Point(4, 24);
            tbMovimentacao.Name = "tbMovimentacao";
            tbMovimentacao.Size = new Size(1138, 788);
            tbMovimentacao.TabIndex = 1;
            tbMovimentacao.Text = "Movimentação";
            // 
            // grpMov
            // 
            grpMov.Controls.Add(txtValorUnit);
            grpMov.Controls.Add(txtQuantMov);
            grpMov.Controls.Add(btnSalvarMov);
            grpMov.Controls.Add(btnExcluirMov);
            grpMov.Controls.Add(txtObservacaoMov);
            grpMov.Controls.Add(lblObservacaoMov);
            grpMov.Controls.Add(lblValorUnit);
            grpMov.Controls.Add(lblQuantMov);
            grpMov.Controls.Add(btnPesqProdMov);
            grpMov.Controls.Add(txtProdutoModal);
            grpMov.Controls.Add(lblProdutoMov);
            grpMov.Controls.Add(cmbTipoMov);
            grpMov.Controls.Add(label2);
            grpMov.Location = new Point(8, 529);
            grpMov.Name = "grpMov";
            grpMov.Size = new Size(821, 259);
            grpMov.TabIndex = 4;
            grpMov.TabStop = false;
            grpMov.Text = "Movimentação";
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(464, 140);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(117, 23);
            txtValorUnit.TabIndex = 5;
            txtValorUnit.Text = "0,00";
            txtValorUnit.TextAlign = HorizontalAlignment.Right;
            // 
            // txtQuantMov
            // 
            txtQuantMov.Location = new Point(464, 79);
            txtQuantMov.Name = "txtQuantMov";
            txtQuantMov.Size = new Size(117, 23);
            txtQuantMov.TabIndex = 4;
            txtQuantMov.Text = "0,000";
            txtQuantMov.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSalvarMov
            // 
            btnSalvarMov.Location = new Point(648, 64);
            btnSalvarMov.Name = "btnSalvarMov";
            btnSalvarMov.Size = new Size(123, 42);
            btnSalvarMov.TabIndex = 6;
            btnSalvarMov.Text = "Salvar";
            btnSalvarMov.UseVisualStyleBackColor = true;
            btnSalvarMov.Click += btnSalvarMov_Click;
            // 
            // btnExcluirMov
            // 
            btnExcluirMov.Location = new Point(648, 144);
            btnExcluirMov.Name = "btnExcluirMov";
            btnExcluirMov.Size = new Size(123, 40);
            btnExcluirMov.TabIndex = 7;
            btnExcluirMov.Text = "Excluir";
            btnExcluirMov.UseVisualStyleBackColor = true;
            btnExcluirMov.Click += btnExcluirMov_Click;
            // 
            // txtObservacaoMov
            // 
            txtObservacaoMov.Location = new Point(13, 148);
            txtObservacaoMov.Multiline = true;
            txtObservacaoMov.Name = "txtObservacaoMov";
            txtObservacaoMov.Size = new Size(413, 71);
            txtObservacaoMov.TabIndex = 1;
            // 
            // lblObservacaoMov
            // 
            lblObservacaoMov.AutoSize = true;
            lblObservacaoMov.Location = new Point(13, 129);
            lblObservacaoMov.Name = "lblObservacaoMov";
            lblObservacaoMov.Size = new Size(69, 15);
            lblObservacaoMov.TabIndex = 10;
            lblObservacaoMov.Text = "Observação";
            // 
            // lblValorUnit
            // 
            lblValorUnit.AutoSize = true;
            lblValorUnit.Location = new Point(462, 122);
            lblValorUnit.Name = "lblValorUnit";
            lblValorUnit.Size = new Size(102, 15);
            lblValorUnit.TabIndex = 8;
            lblValorUnit.Text = "Valor Unitário (R$)";
            // 
            // lblQuantMov
            // 
            lblQuantMov.AutoSize = true;
            lblQuantMov.Location = new Point(462, 61);
            lblQuantMov.Name = "lblQuantMov";
            lblQuantMov.Size = new Size(69, 15);
            lblQuantMov.TabIndex = 6;
            lblQuantMov.Text = "Quantidade";
            // 
            // btnPesqProdMov
            // 
            btnPesqProdMov.BackgroundImage = Properties.Resources.procurar;
            btnPesqProdMov.BackgroundImageLayout = ImageLayout.Zoom;
            btnPesqProdMov.Location = new Point(389, 65);
            btnPesqProdMov.Name = "btnPesqProdMov";
            btnPesqProdMov.Size = new Size(34, 30);
            btnPesqProdMov.TabIndex = 3;
            btnPesqProdMov.UseVisualStyleBackColor = true;
            btnPesqProdMov.Click += btnPesqProdMov_Click;
            // 
            // txtProdutoModal
            // 
            txtProdutoModal.Enabled = false;
            txtProdutoModal.Location = new Point(222, 64);
            txtProdutoModal.Multiline = true;
            txtProdutoModal.Name = "txtProdutoModal";
            txtProdutoModal.Size = new Size(161, 29);
            txtProdutoModal.TabIndex = 4;
            // 
            // lblProdutoMov
            // 
            lblProdutoMov.AutoSize = true;
            lblProdutoMov.Location = new Point(222, 46);
            lblProdutoMov.Name = "lblProdutoMov";
            lblProdutoMov.Size = new Size(50, 15);
            lblProdutoMov.TabIndex = 3;
            lblProdutoMov.Text = "Produto";
            // 
            // cmbTipoMov
            // 
            cmbTipoMov.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoMov.FormattingEnabled = true;
            cmbTipoMov.Location = new Point(13, 64);
            cmbTipoMov.Name = "cmbTipoMov";
            cmbTipoMov.Size = new Size(161, 23);
            cmbTipoMov.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 46);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 0;
            label2.Text = "Tipo";
            // 
            // btnEditarMov
            // 
            btnEditarMov.Location = new Point(1025, 539);
            btnEditarMov.Name = "btnEditarMov";
            btnEditarMov.Size = new Size(94, 29);
            btnEditarMov.TabIndex = 3;
            btnEditarMov.Text = "Editar";
            btnEditarMov.UseVisualStyleBackColor = true;
            btnEditarMov.Click += btnEditarMov_Click;
            // 
            // btnNovaMov
            // 
            btnNovaMov.Location = new Point(859, 539);
            btnNovaMov.Name = "btnNovaMov";
            btnNovaMov.Size = new Size(160, 29);
            btnNovaMov.TabIndex = 2;
            btnNovaMov.Text = "Nova Movimentação";
            btnNovaMov.UseVisualStyleBackColor = true;
            btnNovaMov.Click += btnNovaMov_Click;
            // 
            // dgMovimentacao
            // 
            dgMovimentacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMovimentacao.Location = new Point(8, 128);
            dgMovimentacao.Name = "dgMovimentacao";
            dgMovimentacao.RowHeadersWidth = 51;
            dgMovimentacao.Size = new Size(1130, 395);
            dgMovimentacao.TabIndex = 1;
            dgMovimentacao.SelectionChanged += dgMovimentacao_SelectionChanged;
            // 
            // grpPeriodo
            // 
            grpPeriodo.Controls.Add(lblPesqProdutoMov);
            grpPeriodo.Controls.Add(txtProdutoMov);
            grpPeriodo.Controls.Add(label1);
            grpPeriodo.Controls.Add(dtMov);
            grpPeriodo.Location = new Point(8, 8);
            grpPeriodo.Name = "grpPeriodo";
            grpPeriodo.Size = new Size(1130, 113);
            grpPeriodo.TabIndex = 1;
            grpPeriodo.TabStop = false;
            grpPeriodo.Text = "Período";
            // 
            // lblPesqProdutoMov
            // 
            lblPesqProdutoMov.Location = new Point(332, 47);
            lblPesqProdutoMov.Name = "lblPesqProdutoMov";
            lblPesqProdutoMov.Size = new Size(94, 29);
            lblPesqProdutoMov.TabIndex = 3;
            lblPesqProdutoMov.Text = "Buscar";
            lblPesqProdutoMov.UseVisualStyleBackColor = true;
            // 
            // txtProdutoMov
            // 
            txtProdutoMov.Location = new Point(6, 47);
            txtProdutoMov.Name = "txtProdutoMov";
            txtProdutoMov.Size = new Size(293, 23);
            txtProdutoMov.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "Produto";
            // 
            // dtMov
            // 
            dtMov.Location = new Point(802, 18);
            dtMov.Name = "dtMov";
            dtMov.Size = new Size(322, 23);
            dtMov.TabIndex = 1;
            dtMov.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // tbBalanco
            // 
            tbBalanco.Controls.Add(btnCancelarCsv);
            tbBalanco.Controls.Add(btnExportarCsv);
            tbBalanco.Controls.Add(label5);
            tbBalanco.Controls.Add(dvgMovimentacoesBalanco);
            tbBalanco.Controls.Add(grpValorTotal);
            tbBalanco.Controls.Add(grpSaldo);
            tbBalanco.Controls.Add(grpSaidas);
            tbBalanco.Controls.Add(grpEntradas);
            tbBalanco.Controls.Add(label4);
            tbBalanco.Controls.Add(grpFiltros);
            tbBalanco.Location = new Point(4, 24);
            tbBalanco.Name = "tbBalanco";
            tbBalanco.Size = new Size(1138, 788);
            tbBalanco.TabIndex = 2;
            tbBalanco.Text = "Balanço";
            // 
            // btnCancelarCsv
            // 
            btnCancelarCsv.Location = new Point(585, 659);
            btnCancelarCsv.Name = "btnCancelarCsv";
            btnCancelarCsv.Size = new Size(139, 47);
            btnCancelarCsv.TabIndex = 8;
            btnCancelarCsv.Text = "Cancelar";
            btnCancelarCsv.UseVisualStyleBackColor = true;
            // 
            // btnExportarCsv
            // 
            btnExportarCsv.Location = new Point(402, 659);
            btnExportarCsv.Name = "btnExportarCsv";
            btnExportarCsv.Size = new Size(139, 47);
            btnExportarCsv.TabIndex = 7;
            btnExportarCsv.Text = "Exportar";
            btnExportarCsv.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label5.Location = new Point(457, 306);
            label5.Name = "label5";
            label5.Size = new Size(204, 30);
            label5.TabIndex = 6;
            label5.Text = "MOVIMENTAÇÕES";
            // 
            // dvgMovimentacoesBalanco
            // 
            dvgMovimentacoesBalanco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgMovimentacoesBalanco.Location = new Point(200, 339);
            dvgMovimentacoesBalanco.Name = "dvgMovimentacoesBalanco";
            dvgMovimentacoesBalanco.Size = new Size(737, 239);
            dvgMovimentacoesBalanco.TabIndex = 5;
            // 
            // grpValorTotal
            // 
            grpValorTotal.Controls.Add(lblValorTotalValor);
            grpValorTotal.Location = new Point(760, 184);
            grpValorTotal.Name = "grpValorTotal";
            grpValorTotal.Size = new Size(160, 93);
            grpValorTotal.TabIndex = 0;
            grpValorTotal.TabStop = false;
            grpValorTotal.Text = "Valor Total";
            // 
            // lblValorTotalValor
            // 
            lblValorTotalValor.AutoSize = true;
            lblValorTotalValor.Location = new Point(59, 40);
            lblValorTotalValor.Name = "lblValorTotalValor";
            lblValorTotalValor.Size = new Size(0, 15);
            lblValorTotalValor.TabIndex = 10;
            // 
            // grpSaldo
            // 
            grpSaldo.Controls.Add(lblSaldoValor);
            grpSaldo.Location = new Point(582, 184);
            grpSaldo.Name = "grpSaldo";
            grpSaldo.Size = new Size(150, 93);
            grpSaldo.TabIndex = 4;
            grpSaldo.TabStop = false;
            grpSaldo.Text = "Saldo";
            // 
            // lblSaldoValor
            // 
            lblSaldoValor.AutoSize = true;
            lblSaldoValor.Location = new Point(55, 40);
            lblSaldoValor.Name = "lblSaldoValor";
            lblSaldoValor.Size = new Size(0, 15);
            lblSaldoValor.TabIndex = 9;
            // 
            // grpSaidas
            // 
            grpSaidas.Controls.Add(lblSaidasValor);
            grpSaidas.Location = new Point(387, 184);
            grpSaidas.Name = "grpSaidas";
            grpSaidas.Size = new Size(149, 93);
            grpSaidas.TabIndex = 0;
            grpSaidas.TabStop = false;
            grpSaidas.Text = "Saídas";
            // 
            // lblSaidasValor
            // 
            lblSaidasValor.AutoSize = true;
            lblSaidasValor.Location = new Point(51, 39);
            lblSaidasValor.Name = "lblSaidasValor";
            lblSaidasValor.Size = new Size(0, 15);
            lblSaidasValor.TabIndex = 11;
            // 
            // grpEntradas
            // 
            grpEntradas.Controls.Add(lblEntradasValor);
            grpEntradas.Location = new Point(206, 184);
            grpEntradas.Name = "grpEntradas";
            grpEntradas.Size = new Size(133, 93);
            grpEntradas.TabIndex = 3;
            grpEntradas.TabStop = false;
            grpEntradas.Text = "Entradas";
            // 
            // lblEntradasValor
            // 
            lblEntradasValor.AutoSize = true;
            lblEntradasValor.Location = new Point(40, 39);
            lblEntradasValor.Name = "lblEntradasValor";
            lblEntradasValor.Size = new Size(0, 15);
            lblEntradasValor.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label4.Location = new Point(506, 142);
            label4.Name = "label4";
            label4.Size = new Size(105, 30);
            label4.TabIndex = 2;
            label4.Text = "RESUMO";
            // 
            // grpFiltros
            // 
            grpFiltros.Controls.Add(rdPeriodo);
            grpFiltros.Controls.Add(rdHoje);
            grpFiltros.Controls.Add(button1);
            grpFiltros.Controls.Add(label3);
            grpFiltros.Controls.Add(lblInicio);
            grpFiltros.Controls.Add(dtpFinal);
            grpFiltros.Controls.Add(dtpInicial);
            grpFiltros.Controls.Add(lblTipo);
            grpFiltros.Location = new Point(200, 13);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new Size(731, 126);
            grpFiltros.TabIndex = 1;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Filtros";
            // 
            // rdPeriodo
            // 
            rdPeriodo.AutoSize = true;
            rdPeriodo.Location = new Point(112, 38);
            rdPeriodo.Name = "rdPeriodo";
            rdPeriodo.Size = new Size(66, 19);
            rdPeriodo.TabIndex = 9;
            rdPeriodo.TabStop = true;
            rdPeriodo.Text = "Período";
            rdPeriodo.UseVisualStyleBackColor = true;
            rdPeriodo.CheckedChanged += rdPeriodo_CheckedChanged;
            // 
            // rdHoje
            // 
            rdHoje.AutoSize = true;
            rdHoje.Location = new Point(56, 38);
            rdHoje.Name = "rdHoje";
            rdHoje.Size = new Size(50, 19);
            rdHoje.TabIndex = 8;
            rdHoje.TabStop = true;
            rdHoje.Text = "Hoje";
            rdHoje.UseVisualStyleBackColor = true;
            rdHoje.CheckedChanged += rdHoje_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(562, 60);
            button1.Name = "button1";
            button1.Size = new Size(103, 33);
            button1.TabIndex = 2;
            button1.Text = "Gerar Balanço";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnGerarBalanco_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 74);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 7;
            label3.Text = "Final:";
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Location = new Point(17, 74);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(39, 15);
            lblInicio.TabIndex = 6;
            lblInicio.Text = "Início:";
            // 
            // dtpFinal
            // 
            dtpFinal.Location = new Point(323, 70);
            dtpFinal.Name = "dtpFinal";
            dtpFinal.Size = new Size(200, 23);
            dtpFinal.TabIndex = 5;
            // 
            // dtpInicial
            // 
            dtpInicial.Location = new Point(62, 70);
            dtpInicial.Name = "dtpInicial";
            dtpInicial.Size = new Size(200, 23);
            dtpInicial.TabIndex = 3;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(16, 41);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(34, 15);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Tipo:";
            // 
            // FrmSetup
            // 
            ClientSize = new Size(1146, 816);
            Controls.Add(tbFormSetup);
            MaximizeBox = false;
            Name = "FrmSetup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Balanço de Estoque";
            tbFormSetup.ResumeLayout(false);
            tbProdutos.ResumeLayout(false);
            tbProdutos.PerformLayout();
            grpProduto.ResumeLayout(false);
            grpProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tbMovimentacao.ResumeLayout(false);
            grpMov.ResumeLayout(false);
            grpMov.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgMovimentacao).EndInit();
            grpPeriodo.ResumeLayout(false);
            grpPeriodo.PerformLayout();
            tbBalanco.ResumeLayout(false);
            tbBalanco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgMovimentacoesBalanco).EndInit();
            grpValorTotal.ResumeLayout(false);
            grpValorTotal.PerformLayout();
            grpSaldo.ResumeLayout(false);
            grpSaldo.PerformLayout();
            grpSaidas.ResumeLayout(false);
            grpSaidas.PerformLayout();
            grpEntradas.ResumeLayout(false);
            grpEntradas.PerformLayout();
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbFormSetup;
        private TabPage tbProdutos;
        private TabPage tbMovimentacao;
        private TabPage tbBalanco;
        private DataGridView dataGridView1;
        private GroupBox grpProduto;

        private Label lblNome;
        private TextBox txtNome;
        private Label lblDescricao;
        private TextBox txtDescr;

        private Label lblPrecoCompra;

        private Label lblPrecoVenda;

        private Label lblQuantidade;

        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnPesquisarProduto;
        private TextBox txtPesqProduto;
        private Label lblPesqProduto;
        private GroupBox grpPeriodo;
        private DateTimePicker dtMov;
        private Button lblPesqProdutoMov;
        private TextBox txtProdutoMov;
        private Label label1;
        private DataGridView dgMovimentacao;
        private Button btnEditarMov;
        private Button btnNovaMov;
        private GroupBox grpMov;
        private Label label2;
        private ComboBox cmbTipoMov;
        private TextBox txtProdutoModal;
        private Label lblProdutoMov;
        private Button btnPesqProdMov;
        private Label lblValorUnit;
        private Label lblQuantMov;
        private Label lblObservacaoMov;
        private Button btnSalvarMov;
        private Button btnExcluirMov;
        private TextBox txtObservacaoMov;
        private GroupBox grpFiltros;
        private Label lblTipo;
        private DateTimePicker dtpInicial;
        private RadioButton rdPeriodo;
        private RadioButton rdHoje;
        private Button button1;
        private Label label3;
        private Label lblInicio;
        private DateTimePicker dtpFinal;
        private GroupBox grpValorTotal;
        private GroupBox grpSaldo;
        private GroupBox grpSaidas;
        private GroupBox grpEntradas;
        private Label label4;
        private Label label5;
        private DataGridView dvgMovimentacoesBalanco;
        private Button btnExportarCsv;
        private Button btnCancelarCsv;
        private Label lblValorTotalValor;
        private Label lblSaldoValor;
        private Label lblSaidasValor;
        private Label lblEntradasValor;
        private Personalizados.TextBoxQuantidade txtQuantidade;
        private Personalizados.TextBoxMoeda txtValorVenda;
        private Personalizados.TextBoxMoeda txtValorCompra;
        private Personalizados.TextBoxMoeda txtValorUnit;
        private Personalizados.TextBoxQuantidade txtQuantMov;
    }
}