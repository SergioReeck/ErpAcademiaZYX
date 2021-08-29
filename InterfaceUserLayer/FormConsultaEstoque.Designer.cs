
namespace WinFormsInterfaceUserLayer
{
    partial class frmConsultaEstoque
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
            this.gbResultadosPesquisa = new System.Windows.Forms.GroupBox();
            this.dgvResultadosPesquisa = new System.Windows.Forms.DataGridView();
            this.gbPesquisarProfessor = new System.Windows.Forms.GroupBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.gbResultadosPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosPesquisa)).BeginInit();
            this.gbPesquisarProfessor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbResultadosPesquisa
            // 
            this.gbResultadosPesquisa.Controls.Add(this.dgvResultadosPesquisa);
            this.gbResultadosPesquisa.Location = new System.Drawing.Point(12, 71);
            this.gbResultadosPesquisa.Name = "gbResultadosPesquisa";
            this.gbResultadosPesquisa.Size = new System.Drawing.Size(545, 169);
            this.gbResultadosPesquisa.TabIndex = 9;
            this.gbResultadosPesquisa.TabStop = false;
            this.gbResultadosPesquisa.Text = "Resultado(s) da Pesquisa";
            // 
            // dgvResultadosPesquisa
            // 
            this.dgvResultadosPesquisa.AllowUserToAddRows = false;
            this.dgvResultadosPesquisa.AllowUserToDeleteRows = false;
            this.dgvResultadosPesquisa.AllowUserToResizeColumns = false;
            this.dgvResultadosPesquisa.AllowUserToResizeRows = false;
            this.dgvResultadosPesquisa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResultadosPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResultadosPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadosPesquisa.Location = new System.Drawing.Point(7, 22);
            this.dgvResultadosPesquisa.MultiSelect = false;
            this.dgvResultadosPesquisa.Name = "dgvResultadosPesquisa";
            this.dgvResultadosPesquisa.ReadOnly = true;
            this.dgvResultadosPesquisa.RowHeadersVisible = false;
            this.dgvResultadosPesquisa.RowTemplate.Height = 25;
            this.dgvResultadosPesquisa.RowTemplate.ReadOnly = true;
            this.dgvResultadosPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultadosPesquisa.ShowCellErrors = false;
            this.dgvResultadosPesquisa.ShowCellToolTips = false;
            this.dgvResultadosPesquisa.ShowEditingIcon = false;
            this.dgvResultadosPesquisa.ShowRowErrors = false;
            this.dgvResultadosPesquisa.Size = new System.Drawing.Size(531, 140);
            this.dgvResultadosPesquisa.TabIndex = 5;
            // 
            // gbPesquisarProfessor
            // 
            this.gbPesquisarProfessor.Controls.Add(this.txtPesquisar);
            this.gbPesquisarProfessor.Controls.Add(this.btnPesquisar);
            this.gbPesquisarProfessor.Location = new System.Drawing.Point(12, 12);
            this.gbPesquisarProfessor.Name = "gbPesquisarProfessor";
            this.gbPesquisarProfessor.Size = new System.Drawing.Size(545, 53);
            this.gbPesquisarProfessor.TabIndex = 8;
            this.gbPesquisarProfessor.TabStop = false;
            this.gbPesquisarProfessor.Text = "Dígite o Produto";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(7, 22);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(449, 23);
            this.txtPesquisar.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPesquisar.Location = new System.Drawing.Point(463, 22);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // frmConsultaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(569, 250);
            this.Controls.Add(this.gbResultadosPesquisa);
            this.Controls.Add(this.gbPesquisarProfessor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaEstoque";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Estoque";
            this.gbResultadosPesquisa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosPesquisa)).EndInit();
            this.gbPesquisarProfessor.ResumeLayout(false);
            this.gbPesquisarProfessor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbResultadosPesquisa;
        private System.Windows.Forms.DataGridView dgvResultadosPesquisa;
        private System.Windows.Forms.GroupBox gbPesquisarProfessor;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
    }
}