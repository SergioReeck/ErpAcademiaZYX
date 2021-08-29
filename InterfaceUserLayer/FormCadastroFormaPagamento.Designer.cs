
namespace WinFormsInterfaceUserLayer
{
    partial class frmCadastroFormaPagamento
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
            this.btnCadastrarSalvar = new System.Windows.Forms.Button();
            this.gbCadastrarFormasDePagamento = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvFormasDePagamentoCadastradas = new System.Windows.Forms.DataGridView();
            this.gbFormasDePagamentoCadastradas = new System.Windows.Forms.GroupBox();
            this.gbCadastrarFormasDePagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormasDePagamentoCadastradas)).BeginInit();
            this.gbFormasDePagamentoCadastradas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrarSalvar
            // 
            this.btnCadastrarSalvar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCadastrarSalvar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCadastrarSalvar.FlatAppearance.BorderSize = 0;
            this.btnCadastrarSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnCadastrarSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCadastrarSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarSalvar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarSalvar.ForeColor = System.Drawing.Color.Blue;
            this.btnCadastrarSalvar.Location = new System.Drawing.Point(18, 85);
            this.btnCadastrarSalvar.Name = "btnCadastrarSalvar";
            this.btnCadastrarSalvar.Size = new System.Drawing.Size(108, 23);
            this.btnCadastrarSalvar.TabIndex = 4;
            this.btnCadastrarSalvar.Text = "Cadastrar/Salvar";
            this.btnCadastrarSalvar.UseVisualStyleBackColor = false;
            this.btnCadastrarSalvar.Click += new System.EventHandler(this.btnCadastrarSalvar_Click);
            // 
            // gbCadastrarFormasDePagamento
            // 
            this.gbCadastrarFormasDePagamento.Controls.Add(this.txtDescricao);
            this.gbCadastrarFormasDePagamento.Controls.Add(this.lblDescricao);
            this.gbCadastrarFormasDePagamento.Location = new System.Drawing.Point(12, 12);
            this.gbCadastrarFormasDePagamento.Name = "gbCadastrarFormasDePagamento";
            this.gbCadastrarFormasDePagamento.Size = new System.Drawing.Size(287, 67);
            this.gbCadastrarFormasDePagamento.TabIndex = 1;
            this.gbCadastrarFormasDePagamento.TabStop = false;
            this.gbCadastrarFormasDePagamento.Text = "Cadastrar Forma de Pagamento";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(6, 37);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(275, 23);
            this.txtDescricao.TabIndex = 3;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(6, 19);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 15);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtualizar.ForeColor = System.Drawing.Color.Green;
            this.btnAtualizar.Location = new System.Drawing.Point(99, 341);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 8;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
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
            this.btnEditar.Location = new System.Drawing.Point(18, 341);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvFormasDePagamentoCadastradas
            // 
            this.dgvFormasDePagamentoCadastradas.AllowUserToAddRows = false;
            this.dgvFormasDePagamentoCadastradas.AllowUserToDeleteRows = false;
            this.dgvFormasDePagamentoCadastradas.AllowUserToResizeColumns = false;
            this.dgvFormasDePagamentoCadastradas.AllowUserToResizeRows = false;
            this.dgvFormasDePagamentoCadastradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFormasDePagamentoCadastradas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFormasDePagamentoCadastradas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFormasDePagamentoCadastradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormasDePagamentoCadastradas.Location = new System.Drawing.Point(6, 22);
            this.dgvFormasDePagamentoCadastradas.MultiSelect = false;
            this.dgvFormasDePagamentoCadastradas.Name = "dgvFormasDePagamentoCadastradas";
            this.dgvFormasDePagamentoCadastradas.ReadOnly = true;
            this.dgvFormasDePagamentoCadastradas.RowHeadersVisible = false;
            this.dgvFormasDePagamentoCadastradas.RowTemplate.Height = 25;
            this.dgvFormasDePagamentoCadastradas.RowTemplate.ReadOnly = true;
            this.dgvFormasDePagamentoCadastradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFormasDePagamentoCadastradas.ShowCellToolTips = false;
            this.dgvFormasDePagamentoCadastradas.ShowEditingIcon = false;
            this.dgvFormasDePagamentoCadastradas.Size = new System.Drawing.Size(275, 193);
            this.dgvFormasDePagamentoCadastradas.TabIndex = 6;
            // 
            // gbFormasDePagamentoCadastradas
            // 
            this.gbFormasDePagamentoCadastradas.Controls.Add(this.dgvFormasDePagamentoCadastradas);
            this.gbFormasDePagamentoCadastradas.Location = new System.Drawing.Point(12, 114);
            this.gbFormasDePagamentoCadastradas.Name = "gbFormasDePagamentoCadastradas";
            this.gbFormasDePagamentoCadastradas.Size = new System.Drawing.Size(287, 221);
            this.gbFormasDePagamentoCadastradas.TabIndex = 5;
            this.gbFormasDePagamentoCadastradas.TabStop = false;
            this.gbFormasDePagamentoCadastradas.Text = "Formas de Pagamento Cadastradas";
            // 
            // frmCadastroFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(311, 377);
            this.Controls.Add(this.gbFormasDePagamentoCadastradas);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.gbCadastrarFormasDePagamento);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrarSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroFormaPagamento";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Formas de Pagamento";
            this.gbCadastrarFormasDePagamento.ResumeLayout(false);
            this.gbCadastrarFormasDePagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormasDePagamentoCadastradas)).EndInit();
            this.gbFormasDePagamentoCadastradas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarSalvar;
        private System.Windows.Forms.GroupBox gbCadastrarFormasDePagamento;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvFormasDePagamentoCadastradas;
        private System.Windows.Forms.GroupBox gbFormasDePagamentoCadastradas;
    }
}