
namespace WinFormsInterfaceUserLayer
{
    partial class frmEntradaProduto
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
            this.dgvListaProdutosEntrada = new System.Windows.Forms.DataGridView();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.cmbItens = new System.Windows.Forms.ComboBox();
            this.lblItens = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.gbEntradaProdutos = new System.Windows.Forms.GroupBox();
            this.gbProdutosEntrada = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProdutosEntrada)).BeginInit();
            this.gbEntradaProdutos.SuspendLayout();
            this.gbProdutosEntrada.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaProdutosEntrada
            // 
            this.dgvListaProdutosEntrada.AllowUserToAddRows = false;
            this.dgvListaProdutosEntrada.AllowUserToDeleteRows = false;
            this.dgvListaProdutosEntrada.AllowUserToResizeColumns = false;
            this.dgvListaProdutosEntrada.AllowUserToResizeRows = false;
            this.dgvListaProdutosEntrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaProdutosEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaProdutosEntrada.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListaProdutosEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProdutosEntrada.Location = new System.Drawing.Point(6, 22);
            this.dgvListaProdutosEntrada.Name = "dgvListaProdutosEntrada";
            this.dgvListaProdutosEntrada.RowTemplate.Height = 25;
            this.dgvListaProdutosEntrada.Size = new System.Drawing.Size(346, 215);
            this.dgvListaProdutosEntrada.TabIndex = 0;
            this.dgvListaProdutosEntrada.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(6, 125);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 23);
            this.txtQuantidade.TabIndex = 3;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(112, 125);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 23);
            this.txtValor.TabIndex = 4;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(6, 107);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(69, 15);
            this.lblQuantidade.TabIndex = 5;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(112, 107);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(33, 15);
            this.lblValor.TabIndex = 6;
            this.lblValor.Text = "Valor";
            // 
            // cmbItens
            // 
            this.cmbItens.FormattingEnabled = true;
            this.cmbItens.Location = new System.Drawing.Point(6, 37);
            this.cmbItens.Name = "cmbItens";
            this.cmbItens.Size = new System.Drawing.Size(346, 23);
            this.cmbItens.TabIndex = 7;
            // 
            // lblItens
            // 
            this.lblItens.AutoSize = true;
            this.lblItens.Location = new System.Drawing.Point(6, 19);
            this.lblItens.Name = "lblItens";
            this.lblItens.Size = new System.Drawing.Size(32, 15);
            this.lblItens.TabIndex = 8;
            this.lblItens.Text = "Itens";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(6, 63);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(50, 15);
            this.lblProduto.TabIndex = 10;
            this.lblProduto.Text = "Produto";
            // 
            // txtProduto
            // 
            this.txtProduto.Enabled = false;
            this.txtProduto.Location = new System.Drawing.Point(6, 81);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(346, 23);
            this.txtProduto.TabIndex = 9;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.ForeColor = System.Drawing.Color.Blue;
            this.btnRegistrar.Location = new System.Drawing.Point(18, 451);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(132, 23);
            this.btnRegistrar.TabIndex = 34;
            this.btnRegistrar.Text = "Registrar Entrada";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionar.ForeColor = System.Drawing.Color.Red;
            this.btnAdicionar.Location = new System.Drawing.Point(18, 173);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 35;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // gbEntradaProdutos
            // 
            this.gbEntradaProdutos.Controls.Add(this.lblItens);
            this.gbEntradaProdutos.Controls.Add(this.cmbItens);
            this.gbEntradaProdutos.Controls.Add(this.lblProduto);
            this.gbEntradaProdutos.Controls.Add(this.txtQuantidade);
            this.gbEntradaProdutos.Controls.Add(this.txtValor);
            this.gbEntradaProdutos.Controls.Add(this.lblQuantidade);
            this.gbEntradaProdutos.Controls.Add(this.txtProduto);
            this.gbEntradaProdutos.Controls.Add(this.lblValor);
            this.gbEntradaProdutos.Location = new System.Drawing.Point(12, 12);
            this.gbEntradaProdutos.Name = "gbEntradaProdutos";
            this.gbEntradaProdutos.Size = new System.Drawing.Size(358, 155);
            this.gbEntradaProdutos.TabIndex = 36;
            this.gbEntradaProdutos.TabStop = false;
            this.gbEntradaProdutos.Text = "Entrada de Produto";
            // 
            // gbProdutosEntrada
            // 
            this.gbProdutosEntrada.Controls.Add(this.dgvListaProdutosEntrada);
            this.gbProdutosEntrada.Location = new System.Drawing.Point(12, 202);
            this.gbProdutosEntrada.Name = "gbProdutosEntrada";
            this.gbProdutosEntrada.Size = new System.Drawing.Size(358, 243);
            this.gbProdutosEntrada.TabIndex = 37;
            this.gbProdutosEntrada.TabStop = false;
            this.gbProdutosEntrada.Text = "Produtos da Entrada";
            // 
            // frmEntradaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(383, 484);
            this.Controls.Add(this.gbEntradaProdutos);
            this.Controls.Add(this.gbProdutosEntrada);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnRegistrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEntradaProduto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada De Produtos";
            this.Load += new System.EventHandler(this.FormEntradaDeProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProdutosEntrada)).EndInit();
            this.gbEntradaProdutos.ResumeLayout(false);
            this.gbEntradaProdutos.PerformLayout();
            this.gbProdutosEntrada.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaProdutosEntrada;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ComboBox cmbItens;
        private System.Windows.Forms.Label lblItens;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox gbEntradaProdutos;
        private System.Windows.Forms.GroupBox gbProdutosEntrada;
    }
}