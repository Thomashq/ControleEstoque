namespace ControleEstoque.Formularios
{
    partial class FrmPesquisaProduto
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
            groupBox1 = new GroupBox();
            btnPesquisar = new Button();
            txtProduto = new TextBox();
            lblPesqProd = new Label();
            dataGridView1 = new DataGridView();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPesquisar);
            groupBox1.Controls.Add(txtProduto);
            groupBox1.Controls.Add(lblPesqProd);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(832, 107);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesquisar Produto";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(405, 61);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 29);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtProduto
            // 
            txtProduto.Location = new Point(6, 61);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(377, 27);
            txtProduto.TabIndex = 1;
            // 
            // lblPesqProd
            // 
            lblPesqProd.AutoSize = true;
            lblPesqProd.Location = new Point(6, 38);
            lblPesqProd.Name = "lblPesqProd";
            lblPesqProd.Size = new Size(127, 20);
            lblPesqProd.TabIndex = 0;
            lblPesqProd.Text = "Pesquisar Produto";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(827, 280);
            dataGridView1.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(259, 444);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(154, 48);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(431, 444);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(144, 48);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // FrmPesquisaProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 550);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FrmPesquisaProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPesquisaProduto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblPesqProd;
        private Button btnPesquisar;
        private TextBox txtProduto;
        private DataGridView dataGridView1;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}