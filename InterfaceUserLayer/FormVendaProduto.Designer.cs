
namespace WinFormsInterfaceUserLayer
{
    partial class frmVendaProduto
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
            this.gbVendaProduto = new System.Windows.Forms.GroupBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblItens = new System.Windows.Forms.Label();
            this.cmbItens = new System.Windows.Forms.ComboBox();
            this.gbProdutosVenda = new System.Windows.Forms.GroupBox();
            this.dgvListaProdutoVenda = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.gbVendaProduto.SuspendLayout();
            this.gbProdutosVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProdutoVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // gbVendaProduto
            // 
            this.gbVendaProduto.Controls.Add(this.lblProduto);
            this.gbVendaProduto.Controls.Add(this.txtQuantidade);
            this.gbVendaProduto.Controls.Add(this.txtValor);
            this.gbVendaProduto.Controls.Add(this.lblQuantidade);
            this.gbVendaProduto.Controls.Add(this.txtProduto);
            this.gbVendaProduto.Controls.Add(this.lblValor);
            this.gbVendaProduto.Controls.Add(this.lblItens);
            this.gbVendaProduto.Controls.Add(this.cmbItens);
            this.gbVendaProduto.Location = new System.Drawing.Point(12, 12);
            this.gbVendaProduto.Name = "gbVendaProduto";
            this.gbVendaProduto.Size = new System.Drawing.Size(358, 155);
            this.gbVendaProduto.TabIndex = 40;
            this.gbVendaProduto.TabStop = false;
            this.gbVendaProduto.Text = "Venda de Produto";
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
            // txtProduto
            // 
            this.txtProduto.Enabled = false;
            this.txtProduto.Location = new System.Drawing.Point(6, 81);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(346, 23);
            this.txtProduto.TabIndex = 9;
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
            // lblItens
            // 
            this.lblItens.AutoSize = true;
            this.lblItens.Location = new System.Drawing.Point(6, 19);
            this.lblItens.Name = "lblItens";
            this.lblItens.Size = new System.Drawing.Size(32, 15);
            this.lblItens.TabIndex = 19;
            this.lblItens.Text = "Itens";
            // 
            // cmbItens
            // 
            this.cmbItens.FormattingEnabled = true;
            this.cmbItens.Location = new System.Drawing.Point(6, 37);
            this.cmbItens.Name = "cmbItens";
            this.cmbItens.Size = new System.Drawing.Size(346, 23);
            this.cmbItens.TabIndex = 18;
            // 
            // gbProdutosVenda
            // 
            this.gbProdutosVenda.Controls.Add(this.dgvListaProdutoVenda);
            this.gbProdutosVenda.Location = new System.Drawing.Point(12, 202);
            this.gbProdutosVenda.Name = "gbProdutosVenda";
            this.gbProdutosVenda.Size = new System.Drawing.Size(358, 243);
            this.gbProdutosVenda.TabIndex = 41;
            this.gbProdutosVenda.TabStop = false;
            this.gbProdutosVenda.Text = "Produtos da Venda";
            // 
            // dgvListaProdutoVenda
            // 
            this.dgvListaProdutoVenda.AllowUserToAddRows = false;
            this.dgvListaProdutoVenda.AllowUserToDeleteRows = false;
            this.dgvListaProdutoVenda.AllowUserToResizeColumns = false;
            this.dgvListaProdutoVenda.AllowUserToResizeRows = false;
            this.dgvListaProdutoVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaProdutoVenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaProdutoVenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListaProdutoVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProdutoVenda.Location = new System.Drawing.Point(6, 22);
            this.dgvListaProdutoVenda.Name = "dgvListaProdutoVenda";
            this.dgvListaProdutoVenda.RowTemplate.Height = 25;
            this.dgvListaProdutoVenda.Size = new System.Drawing.Size(346, 216);
            this.dgvListaProdutoVenda.TabIndex = 0;
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
            this.btnAdicionar.TabIndex = 39;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
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
            this.btnRegistrar.TabIndex = 38;
            this.btnRegistrar.Text = "Registrar Venda";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // frmVendaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(382, 484);
            this.Controls.Add(this.gbVendaProduto);
            this.Controls.Add(this.gbProdutosVenda);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnRegistrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVendaProduto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda de Produtos";
            this.Load += new System.EventHandler(this.FormVendaDeProduto_Load);
            this.gbVendaProduto.ResumeLayout(false);
            this.gbVendaProduto.PerformLayout();
            this.gbProdutosVenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProdutoVenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVendaProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblItens;
        private System.Windows.Forms.ComboBox cmbItens;
        private System.Windows.Forms.GroupBox gbProdutosVenda;
        private System.Windows.Forms.DataGridView dgvListaProdutoVenda;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRegistrar;
    }
}