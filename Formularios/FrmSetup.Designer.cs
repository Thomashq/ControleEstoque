using ControleEstoque.Masks;

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
            lblNome = new Label();
            txtNome = new TextBox();
            lblDescricao = new Label();
            txtDescr = new TextBox();
            lblPrecoCompra = new Label();
            txtValorCompra = new CurrencyTextBox();
            lblPrecoVenda = new Label();
            txtValorVenda = new CurrencyTextBox();
            lblQuantidade = new Label();
            txtQuantidade = new TextBox();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnNovo = new Button();
            btnEditar = new Button();
            dataGridView1 = new DataGridView();
            tbMovimentacao = new TabPage();
            grpMov = new GroupBox();
            btnSalvarMov = new Button();
            btnExcluirMov = new Button();
            txtObservacaoMov = new TextBox();
            lblObservacaoMov = new Label();
            txtValorUnitario = new CurrencyTextBox();
            lblValorUnit = new Label();
            txtQuantMov = new TextBox();
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
            grpFiltros = new GroupBox();
            tbFormSetup.SuspendLayout();
            tbProdutos.SuspendLayout();
            grpProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tbMovimentacao.SuspendLayout();
            grpMov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgMovimentacao).BeginInit();
            grpPeriodo.SuspendLayout();
            tbBalanco.SuspendLayout();
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
            tbFormSetup.Size = new Size(1058, 764);
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
            tbProdutos.Location = new Point(4, 29);
            tbProdutos.Name = "tbProdutos";
            tbProdutos.Size = new Size(1050, 731);
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
            txtPesqProduto.Size = new Size(254, 27);
            txtPesqProduto.TabIndex = 5;
            txtPesqProduto.KeyDown += txtPesqProduto_KeyDown;
            // 
            // lblPesqProduto
            // 
            lblPesqProduto.AutoSize = true;
            lblPesqProduto.Location = new Point(16, 17);
            lblPesqProduto.Name = "lblPesqProduto";
            lblPesqProduto.Size = new Size(127, 20);
            lblPesqProduto.TabIndex = 4;
            lblPesqProduto.Text = "Pesquisar Produto";
            // 
            // grpProduto
            // 
            grpProduto.Controls.Add(lblNome);
            grpProduto.Controls.Add(txtNome);
            grpProduto.Controls.Add(lblDescricao);
            grpProduto.Controls.Add(txtDescr);
            grpProduto.Controls.Add(lblPrecoCompra);
            grpProduto.Controls.Add(txtValorCompra);
            grpProduto.Controls.Add(lblPrecoVenda);
            grpProduto.Controls.Add(txtValorVenda);
            grpProduto.Controls.Add(lblQuantidade);
            grpProduto.Controls.Add(txtQuantidade);
            grpProduto.Controls.Add(btnSalvar);
            grpProduto.Controls.Add(btnExcluir);
            grpProduto.Location = new Point(8, 467);
            grpProduto.Name = "grpProduto";
            grpProduto.Size = new Size(710, 263);
            grpProduto.TabIndex = 0;
            grpProduto.TabStop = false;
            grpProduto.Text = "Produto";
            // 
            // lblNome
            // 
            lblNome.Location = new Point(35, 40);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(100, 23);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(35, 63);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(248, 27);
            txtNome.TabIndex = 1;
            // 
            // lblDescricao
            // 
            lblDescricao.Location = new Point(35, 100);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(100, 23);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descrição";
            // 
            // txtDescr
            // 
            txtDescr.Location = new Point(35, 123);
            txtDescr.Multiline = true;
            txtDescr.Name = "txtDescr";
            txtDescr.Size = new Size(248, 84);
            txtDescr.TabIndex = 3;
            // 
            // lblPrecoCompra
            // 
            lblPrecoCompra.Location = new Point(316, 40);
            lblPrecoCompra.Name = "lblPrecoCompra";
            lblPrecoCompra.Size = new Size(100, 23);
            lblPrecoCompra.TabIndex = 4;
            lblPrecoCompra.Text = "Preço Compra (R$)";
            // 
            // txtValorCompra
            // 
            txtValorCompra.Location = new Point(316, 63);
            txtValorCompra.Name = "txtValorCompra";
            txtValorCompra.Size = new Size(178, 27);
            txtValorCompra.TabIndex = 5;
            txtValorCompra.Text = "0,00";
            txtValorCompra.TextAlign = HorizontalAlignment.Right;
            // 
            // lblPrecoVenda
            // 
            lblPrecoVenda.Location = new Point(316, 100);
            lblPrecoVenda.Name = "lblPrecoVenda";
            lblPrecoVenda.Size = new Size(100, 23);
            lblPrecoVenda.TabIndex = 6;
            lblPrecoVenda.Text = "Preço Venda (R$)";
            // 
            // txtValorVenda
            // 
            txtValorVenda.Location = new Point(316, 123);
            txtValorVenda.Name = "txtValorVenda";
            txtValorVenda.Size = new Size(178, 27);
            txtValorVenda.TabIndex = 7;
            txtValorVenda.Text = "0,00";
            txtValorVenda.TextAlign = HorizontalAlignment.Right;
            // 
            // lblQuantidade
            // 
            lblQuantidade.Location = new Point(519, 40);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(100, 23);
            lblQuantidade.TabIndex = 8;
            lblQuantidade.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(519, 63);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(150, 27);
            txtQuantidade.TabIndex = 9;
            txtQuantidade.KeyPress += txtQuantidade_KeyPress;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(482, 196);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(595, 196);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(771, 467);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(128, 29);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo Produto";
            btnNovo.Click += btnNovo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(923, 467);
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
            dataGridView1.Size = new Size(1046, 362);
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
            tbMovimentacao.Location = new Point(4, 29);
            tbMovimentacao.Name = "tbMovimentacao";
            tbMovimentacao.Size = new Size(1050, 731);
            tbMovimentacao.TabIndex = 1;
            tbMovimentacao.Text = "Movimentação";
            // 
            // grpMov
            // 
            grpMov.Controls.Add(btnSalvarMov);
            grpMov.Controls.Add(btnExcluirMov);
            grpMov.Controls.Add(txtObservacaoMov);
            grpMov.Controls.Add(lblObservacaoMov);
            grpMov.Controls.Add(txtValorUnitario);
            grpMov.Controls.Add(lblValorUnit);
            grpMov.Controls.Add(txtQuantMov);
            grpMov.Controls.Add(lblQuantMov);
            grpMov.Controls.Add(btnPesqProdMov);
            grpMov.Controls.Add(txtProdutoModal);
            grpMov.Controls.Add(lblProdutoMov);
            grpMov.Controls.Add(cmbTipoMov);
            grpMov.Controls.Add(label2);
            grpMov.Location = new Point(8, 529);
            grpMov.Name = "grpMov";
            grpMov.Size = new Size(758, 194);
            grpMov.TabIndex = 4;
            grpMov.TabStop = false;
            grpMov.Text = "Movimentação";
            // 
            // btnSalvarMov
            // 
            btnSalvarMov.Location = new Point(609, 70);
            btnSalvarMov.Name = "btnSalvarMov";
            btnSalvarMov.Size = new Size(94, 29);
            btnSalvarMov.TabIndex = 5;
            btnSalvarMov.Text = "Salvar";
            btnSalvarMov.UseVisualStyleBackColor = true;
            btnSalvarMov.Click += btnSalvarMov_Click;
            // 
            // btnExcluirMov
            // 
            btnExcluirMov.Location = new Point(609, 129);
            btnExcluirMov.Name = "btnExcluirMov";
            btnExcluirMov.Size = new Size(94, 29);
            btnExcluirMov.TabIndex = 6;
            btnExcluirMov.Text = "Excluir";
            btnExcluirMov.UseVisualStyleBackColor = true;
            btnExcluirMov.Click += btnExcluirMov_Click;
            // 
            // txtObservacaoMov
            // 
            txtObservacaoMov.Location = new Point(13, 117);
            txtObservacaoMov.Multiline = true;
            txtObservacaoMov.Name = "txtObservacaoMov";
            txtObservacaoMov.Size = new Size(413, 71);
            txtObservacaoMov.TabIndex = 11;
            // 
            // lblObservacaoMov
            // 
            lblObservacaoMov.AutoSize = true;
            lblObservacaoMov.Location = new Point(13, 91);
            lblObservacaoMov.Name = "lblObservacaoMov";
            lblObservacaoMov.Size = new Size(87, 20);
            lblObservacaoMov.TabIndex = 10;
            lblObservacaoMov.Text = "Observação";
            // 
            // txtValorUnitario
            // 
            txtValorUnitario.Location = new Point(442, 117);
            txtValorUnitario.Name = "txtValorUnitario";
            txtValorUnitario.Size = new Size(131, 27);
            txtValorUnitario.TabIndex = 9;
            txtValorUnitario.Text = "0,00";
            txtValorUnitario.TextAlign = HorizontalAlignment.Right;
            // 
            // lblValorUnit
            // 
            lblValorUnit.AutoSize = true;
            lblValorUnit.Location = new Point(442, 91);
            lblValorUnit.Name = "lblValorUnit";
            lblValorUnit.Size = new Size(131, 20);
            lblValorUnit.TabIndex = 8;
            lblValorUnit.Text = "Valor Unitário (R$)";
            // 
            // txtQuantMov
            // 
            txtQuantMov.Location = new Point(442, 54);
            txtQuantMov.Name = "txtQuantMov";
            txtQuantMov.Size = new Size(131, 27);
            txtQuantMov.TabIndex = 7;
            // 
            // lblQuantMov
            // 
            lblQuantMov.AutoSize = true;
            lblQuantMov.Location = new Point(442, 30);
            lblQuantMov.Name = "lblQuantMov";
            lblQuantMov.Size = new Size(87, 20);
            lblQuantMov.TabIndex = 6;
            lblQuantMov.Text = "Quantidade";
            // 
            // btnPesqProdMov
            // 
            btnPesqProdMov.BackgroundImage = Properties.Resources.procurar;
            btnPesqProdMov.BackgroundImageLayout = ImageLayout.Zoom;
            btnPesqProdMov.Location = new Point(392, 52);
            btnPesqProdMov.Name = "btnPesqProdMov";
            btnPesqProdMov.Size = new Size(34, 30);
            btnPesqProdMov.TabIndex = 5;
            btnPesqProdMov.UseVisualStyleBackColor = true;
            btnPesqProdMov.Click += btnPesqProdMov_Click;
            // 
            // txtProdutoModal
            // 
            txtProdutoModal.Enabled = false;
            txtProdutoModal.Location = new Point(222, 52);
            txtProdutoModal.Multiline = true;
            txtProdutoModal.Name = "txtProdutoModal";
            txtProdutoModal.Size = new Size(161, 29);
            txtProdutoModal.TabIndex = 4;
            // 
            // lblProdutoMov
            // 
            lblProdutoMov.AutoSize = true;
            lblProdutoMov.Location = new Point(222, 29);
            lblProdutoMov.Name = "lblProdutoMov";
            lblProdutoMov.Size = new Size(62, 20);
            lblProdutoMov.TabIndex = 3;
            lblProdutoMov.Text = "Produto";
            // 
            // cmbTipoMov
            // 
            cmbTipoMov.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoMov.FormattingEnabled = true;
            cmbTipoMov.Location = new Point(13, 53);
            cmbTipoMov.Name = "cmbTipoMov";
            cmbTipoMov.Size = new Size(161, 28);
            cmbTipoMov.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 30);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 0;
            label2.Text = "Tipo";
            // 
            // btnEditarMov
            // 
            btnEditarMov.Location = new Point(948, 539);
            btnEditarMov.Name = "btnEditarMov";
            btnEditarMov.Size = new Size(94, 29);
            btnEditarMov.TabIndex = 3;
            btnEditarMov.Text = "Editar";
            btnEditarMov.UseVisualStyleBackColor = true;
            btnEditarMov.Click += btnEditarMov_Click;
            // 
            // btnNovaMov
            // 
            btnNovaMov.Location = new Point(780, 539);
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
            dgMovimentacao.Size = new Size(1039, 395);
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
            grpPeriodo.Size = new Size(1039, 113);
            grpPeriodo.TabIndex = 0;
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
            txtProdutoMov.Size = new Size(293, 27);
            txtProdutoMov.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 1;
            label1.Text = "Produto";
            // 
            // dtMov
            // 
            dtMov.Location = new Point(712, 17);
            dtMov.Name = "dtMov";
            dtMov.Size = new Size(322, 27);
            dtMov.TabIndex = 1;
            dtMov.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // tbBalanco
            // 
            tbBalanco.Controls.Add(grpFiltros);
            tbBalanco.Location = new Point(4, 29);
            tbBalanco.Name = "tbBalanco";
            tbBalanco.Size = new Size(1050, 731);
            tbBalanco.TabIndex = 2;
            tbBalanco.Text = "Balanço";
            // 
            // grpFiltros
            // 
            grpFiltros.Location = new Point(3, 3);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new Size(1044, 176);
            grpFiltros.TabIndex = 1;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Filtros";
            // 
            // FrmSetup
            // 
            ClientSize = new Size(1058, 764);
            Controls.Add(tbFormSetup);
            MaximizeBox = false;
            Name = "FrmSetup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSetup";
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
        private CurrencyTextBox txtValorCompra;

        private Label lblPrecoVenda;
        private CurrencyTextBox txtValorVenda;

        private Label lblQuantidade;
        private TextBox txtQuantidade;

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
        private CurrencyTextBox txtValorUnitario;
        private Label lblValorUnit;
        private TextBox txtQuantMov;
        private Label lblQuantMov;
        private Label lblObservacaoMov;
        private Button btnSalvarMov;
        private Button btnExcluirMov;
        private TextBox txtObservacaoMov;
        private GroupBox grpFiltros;
    }
}