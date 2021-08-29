
namespace WinFormsInterfaceUserLayer
{
    partial class frmCadastroModalidade
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
            this.gbCadastrarModalidade = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvModalidadesCadastradas = new System.Windows.Forms.DataGridView();
            this.btnCadastrarSalvar = new System.Windows.Forms.Button();
            this.gbModalidadesCadastradas = new System.Windows.Forms.GroupBox();
            this.gbCadastrarModalidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalidadesCadastradas)).BeginInit();
            this.gbModalidadesCadastradas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCadastrarModalidade
            // 
            this.gbCadastrarModalidade.BackColor = System.Drawing.Color.Silver;
            this.gbCadastrarModalidade.Controls.Add(this.txtValor);
            this.gbCadastrarModalidade.Controls.Add(this.txtDescricao);
            this.gbCadastrarModalidade.Controls.Add(this.lblValor);
            this.gbCadastrarModalidade.Controls.Add(this.lblDescricao);
            this.gbCadastrarModalidade.Location = new System.Drawing.Point(12, 12);
            this.gbCadastrarModalidade.Name = "gbCadastrarModalidade";
            this.gbCadastrarModalidade.Size = new System.Drawing.Size(293, 66);
            this.gbCadastrarModalidade.TabIndex = 1;
            this.gbCadastrarModalidade.TabStop = false;
            this.gbCadastrarModalidade.Text = "Cadastrar Modalidade";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(187, 37);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 23);
            this.txtValor.TabIndex = 7;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(6, 37);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(175, 23);
            this.txtDescricao.TabIndex = 3;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(187, 19);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(33, 15);
            this.lblValor.TabIndex = 6;
            this.lblValor.Text = "Valor";
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
            this.btnAtualizar.TabIndex = 12;
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
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvModalidadesCadastradas
            // 
            this.dgvModalidadesCadastradas.AllowUserToAddRows = false;
            this.dgvModalidadesCadastradas.AllowUserToDeleteRows = false;
            this.dgvModalidadesCadastradas.AllowUserToResizeColumns = false;
            this.dgvModalidadesCadastradas.AllowUserToResizeRows = false;
            this.dgvModalidadesCadastradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModalidadesCadastradas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvModalidadesCadastradas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvModalidadesCadastradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModalidadesCadastradas.Location = new System.Drawing.Point(6, 22);
            this.dgvModalidadesCadastradas.MultiSelect = false;
            this.dgvModalidadesCadastradas.Name = "dgvModalidadesCadastradas";
            this.dgvModalidadesCadastradas.ReadOnly = true;
            this.dgvModalidadesCadastradas.RowHeadersVisible = false;
            this.dgvModalidadesCadastradas.RowTemplate.Height = 25;
            this.dgvModalidadesCadastradas.RowTemplate.ReadOnly = true;
            this.dgvModalidadesCadastradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModalidadesCadastradas.ShowCellToolTips = false;
            this.dgvModalidadesCadastradas.ShowEditingIcon = false;
            this.dgvModalidadesCadastradas.Size = new System.Drawing.Size(281, 193);
            this.dgvModalidadesCadastradas.TabIndex = 10;
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
            this.btnCadastrarSalvar.Location = new System.Drawing.Point(18, 84);
            this.btnCadastrarSalvar.Name = "btnCadastrarSalvar";
            this.btnCadastrarSalvar.Size = new System.Drawing.Size(108, 23);
            this.btnCadastrarSalvar.TabIndex = 8;
            this.btnCadastrarSalvar.Text = "Cadastrar/Salvar";
            this.btnCadastrarSalvar.UseVisualStyleBackColor = false;
            this.btnCadastrarSalvar.Click += new System.EventHandler(this.btnCadastrarSalvar_Click);
            // 
            // gbModalidadesCadastradas
            // 
            this.gbModalidadesCadastradas.Controls.Add(this.dgvModalidadesCadastradas);
            this.gbModalidadesCadastradas.Location = new System.Drawing.Point(12, 113);
            this.gbModalidadesCadastradas.Name = "gbModalidadesCadastradas";
            this.gbModalidadesCadastradas.Size = new System.Drawing.Size(293, 222);
            this.gbModalidadesCadastradas.TabIndex = 9;
            this.gbModalidadesCadastradas.TabStop = false;
            this.gbModalidadesCadastradas.Text = "Modalidades Cadastradas";
            // 
            // frmCadastroModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(318, 378);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.gbModalidadesCadastradas);
            this.Controls.Add(this.gbCadastrarModalidade);
            this.Controls.Add(this.btnCadastrarSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroModalidade";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Modalidades";
            this.gbCadastrarModalidade.ResumeLayout(false);
            this.gbCadastrarModalidade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalidadesCadastradas)).EndInit();
            this.gbModalidadesCadastradas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCadastrarModalidade;
        private System.Windows.Forms.DataGridView dgvModalidadesCadastradas;
        private System.Windows.Forms.Button btnCadastrarSalvar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.GroupBox gbModalidadesCadastradas;
    }
}