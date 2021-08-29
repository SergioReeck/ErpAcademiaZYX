
namespace WinFormsInterfaceUserLayer
{
    partial class frmEditProduto
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gbDadosDoProduto = new System.Windows.Forms.GroupBox();
            this.lblValorDeVenda = new System.Windows.Forms.Label();
            this.txtValorDeVenda = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.lblValorDeCusto = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtValorDeCusto = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.gbDadosDoProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.ForeColor = System.Drawing.Color.Green;
            this.btnLimpar.Location = new System.Drawing.Point(180, 131);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 42;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.ForeColor = System.Drawing.Color.Red;
            this.btnEditar.Location = new System.Drawing.Point(99, 131);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 41;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.Color.Blue;
            this.btnCadastrar.Location = new System.Drawing.Point(18, 131);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 40;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // gbDadosDoProduto
            // 
            this.gbDadosDoProduto.Controls.Add(this.lblValorDeVenda);
            this.gbDadosDoProduto.Controls.Add(this.txtValorDeVenda);
            this.gbDadosDoProduto.Controls.Add(this.cmbCategoria);
            this.gbDadosDoProduto.Controls.Add(this.txtEstoque);
            this.gbDadosDoProduto.Controls.Add(this.lblValorDeCusto);
            this.gbDadosDoProduto.Controls.Add(this.txtDescricao);
            this.gbDadosDoProduto.Controls.Add(this.lblDescricao);
            this.gbDadosDoProduto.Controls.Add(this.txtValorDeCusto);
            this.gbDadosDoProduto.Controls.Add(this.lblEstoque);
            this.gbDadosDoProduto.Controls.Add(this.lblCategoria);
            this.gbDadosDoProduto.ForeColor = System.Drawing.Color.Black;
            this.gbDadosDoProduto.Location = new System.Drawing.Point(12, 13);
            this.gbDadosDoProduto.Name = "gbDadosDoProduto";
            this.gbDadosDoProduto.Size = new System.Drawing.Size(637, 112);
            this.gbDadosDoProduto.TabIndex = 39;
            this.gbDadosDoProduto.TabStop = false;
            this.gbDadosDoProduto.Text = "Dados do Produto";
            // 
            // lblValorDeVenda
            // 
            this.lblValorDeVenda.AutoSize = true;
            this.lblValorDeVenda.Location = new System.Drawing.Point(330, 63);
            this.lblValorDeVenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorDeVenda.Name = "lblValorDeVenda";
            this.lblValorDeVenda.Size = new System.Drawing.Size(84, 15);
            this.lblValorDeVenda.TabIndex = 15;
            this.lblValorDeVenda.Text = "Valor de Venda";
            // 
            // txtValorDeVenda
            // 
            this.txtValorDeVenda.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorDeVenda.Location = new System.Drawing.Point(330, 81);
            this.txtValorDeVenda.Name = "txtValorDeVenda";
            this.txtValorDeVenda.Size = new System.Drawing.Size(133, 23);
            this.txtValorDeVenda.TabIndex = 16;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.BackColor = System.Drawing.SystemColors.Window;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(426, 37);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(204, 23);
            this.cmbCategoria.TabIndex = 14;
            // 
            // txtEstoque
            // 
            this.txtEstoque.BackColor = System.Drawing.SystemColors.Window;
            this.txtEstoque.Location = new System.Drawing.Point(6, 81);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(179, 23);
            this.txtEstoque.TabIndex = 7;
            // 
            // lblValorDeCusto
            // 
            this.lblValorDeCusto.AutoSize = true;
            this.lblValorDeCusto.Location = new System.Drawing.Point(191, 63);
            this.lblValorDeCusto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorDeCusto.Name = "lblValorDeCusto";
            this.lblValorDeCusto.Size = new System.Drawing.Size(83, 15);
            this.lblValorDeCusto.TabIndex = 6;
            this.lblValorDeCusto.Text = "Valor de Custo";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescricao.Location = new System.Drawing.Point(6, 37);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(413, 23);
            this.txtDescricao.TabIndex = 3;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(6, 19);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 15);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtValorDeCusto
            // 
            this.txtValorDeCusto.Location = new System.Drawing.Point(191, 81);
            this.txtValorDeCusto.Name = "txtValorDeCusto";
            this.txtValorDeCusto.Size = new System.Drawing.Size(133, 23);
            this.txtValorDeCusto.TabIndex = 9;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(6, 63);
            this.lblEstoque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(49, 15);
            this.lblEstoque.TabIndex = 8;
            this.lblEstoque.Text = "Estoque";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(426, 19);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(58, 15);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria";
            // 
            // frmEditProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(661, 168);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.gbDadosDoProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditProduto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Produto";
            this.gbDadosDoProduto.ResumeLayout(false);
            this.gbDadosDoProduto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox gbDadosDoProduto;
        private System.Windows.Forms.Label lblValorDeVenda;
        private System.Windows.Forms.TextBox txtValorDeVenda;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label lblValorDeCusto;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtValorDeCusto;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblCategoria;
    }
}