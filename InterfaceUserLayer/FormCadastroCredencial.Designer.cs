
namespace WinFormsInterfaceUserLayer
{
    partial class frmCadastroCredencial
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.gbCadastrarCredencial = new System.Windows.Forms.GroupBox();
            this.cmbTipoCredencial = new System.Windows.Forms.ComboBox();
            this.lblTipoCredencial = new System.Windows.Forms.Label();
            this.dgvCredenciaisCadastradas = new System.Windows.Forms.DataGridView();
            this.gbCredenciaisCadastradas = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.gbCadastrarCredencial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredenciaisCadastradas)).BeginInit();
            this.gbCredenciaisCadastradas.SuspendLayout();
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
            this.btnCadastrarSalvar.Location = new System.Drawing.Point(19, 131);
            this.btnCadastrarSalvar.Name = "btnCadastrarSalvar";
            this.btnCadastrarSalvar.Size = new System.Drawing.Size(108, 23);
            this.btnCadastrarSalvar.TabIndex = 36;
            this.btnCadastrarSalvar.Text = "Cadastrar/Salvar";
            this.btnCadastrarSalvar.UseVisualStyleBackColor = false;
            this.btnCadastrarSalvar.Click += new System.EventHandler(this.btnCadastrarSalvar_Click);
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
            this.btnEditar.Location = new System.Drawing.Point(19, 395);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 37;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(7, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(332, 23);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(7, 19);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(7, 81);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(276, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(7, 63);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 15);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(289, 81);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(194, 23);
            this.txtSenha.TabIndex = 11;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(289, 63);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(39, 15);
            this.lblSenha.TabIndex = 10;
            this.lblSenha.Text = "Senha";
            // 
            // gbCadastrarCredencial
            // 
            this.gbCadastrarCredencial.Controls.Add(this.cmbTipoCredencial);
            this.gbCadastrarCredencial.Controls.Add(this.lblTipoCredencial);
            this.gbCadastrarCredencial.Controls.Add(this.txtNome);
            this.gbCadastrarCredencial.Controls.Add(this.lblNome);
            this.gbCadastrarCredencial.Controls.Add(this.txtEmail);
            this.gbCadastrarCredencial.Controls.Add(this.lblEmail);
            this.gbCadastrarCredencial.Controls.Add(this.txtSenha);
            this.gbCadastrarCredencial.Controls.Add(this.lblSenha);
            this.gbCadastrarCredencial.ForeColor = System.Drawing.Color.Black;
            this.gbCadastrarCredencial.Location = new System.Drawing.Point(12, 12);
            this.gbCadastrarCredencial.Name = "gbCadastrarCredencial";
            this.gbCadastrarCredencial.Size = new System.Drawing.Size(491, 113);
            this.gbCadastrarCredencial.TabIndex = 2;
            this.gbCadastrarCredencial.TabStop = false;
            this.gbCadastrarCredencial.Text = "Cadastrar Credencial";
            // 
            // cmbTipoCredencial
            // 
            this.cmbTipoCredencial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCredencial.FormattingEnabled = true;
            this.cmbTipoCredencial.Items.AddRange(new object[] {
            "Administrador",
            "Recepção",
            "Professor"});
            this.cmbTipoCredencial.Location = new System.Drawing.Point(345, 37);
            this.cmbTipoCredencial.Name = "cmbTipoCredencial";
            this.cmbTipoCredencial.Size = new System.Drawing.Size(138, 23);
            this.cmbTipoCredencial.TabIndex = 25;
            // 
            // lblTipoCredencial
            // 
            this.lblTipoCredencial.AutoSize = true;
            this.lblTipoCredencial.Location = new System.Drawing.Point(345, 19);
            this.lblTipoCredencial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoCredencial.Name = "lblTipoCredencial";
            this.lblTipoCredencial.Size = new System.Drawing.Size(105, 15);
            this.lblTipoCredencial.TabIndex = 24;
            this.lblTipoCredencial.Text = "Tipo de Credencial";
            // 
            // dgvCredenciaisCadastradas
            // 
            this.dgvCredenciaisCadastradas.AllowUserToAddRows = false;
            this.dgvCredenciaisCadastradas.AllowUserToDeleteRows = false;
            this.dgvCredenciaisCadastradas.AllowUserToResizeColumns = false;
            this.dgvCredenciaisCadastradas.AllowUserToResizeRows = false;
            this.dgvCredenciaisCadastradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCredenciaisCadastradas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCredenciaisCadastradas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCredenciaisCadastradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCredenciaisCadastradas.Location = new System.Drawing.Point(7, 22);
            this.dgvCredenciaisCadastradas.MultiSelect = false;
            this.dgvCredenciaisCadastradas.Name = "dgvCredenciaisCadastradas";
            this.dgvCredenciaisCadastradas.ReadOnly = true;
            this.dgvCredenciaisCadastradas.RowHeadersVisible = false;
            this.dgvCredenciaisCadastradas.RowTemplate.Height = 25;
            this.dgvCredenciaisCadastradas.RowTemplate.ReadOnly = true;
            this.dgvCredenciaisCadastradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCredenciaisCadastradas.ShowCellErrors = false;
            this.dgvCredenciaisCadastradas.ShowCellToolTips = false;
            this.dgvCredenciaisCadastradas.ShowEditingIcon = false;
            this.dgvCredenciaisCadastradas.ShowRowErrors = false;
            this.dgvCredenciaisCadastradas.Size = new System.Drawing.Size(476, 199);
            this.dgvCredenciaisCadastradas.TabIndex = 5;
            // 
            // gbCredenciaisCadastradas
            // 
            this.gbCredenciaisCadastradas.Controls.Add(this.dgvCredenciaisCadastradas);
            this.gbCredenciaisCadastradas.Location = new System.Drawing.Point(12, 160);
            this.gbCredenciaisCadastradas.Name = "gbCredenciaisCadastradas";
            this.gbCredenciaisCadastradas.Size = new System.Drawing.Size(491, 229);
            this.gbCredenciaisCadastradas.TabIndex = 4;
            this.gbCredenciaisCadastradas.TabStop = false;
            this.gbCredenciaisCadastradas.Text = "Credenciais Cadastradas";
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
            this.btnAtualizar.Location = new System.Drawing.Point(100, 395);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 36;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // frmCadastroCredencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(515, 429);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrarSalvar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gbCadastrarCredencial);
            this.Controls.Add(this.gbCredenciaisCadastradas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroCredencial";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Credenciais";
            this.gbCadastrarCredencial.ResumeLayout(false);
            this.gbCadastrarCredencial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredenciaisCadastradas)).EndInit();
            this.gbCredenciaisCadastradas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.GroupBox gbCadastrarCredencial;
        private System.Windows.Forms.DataGridView dgvCredenciaisCadastradas;
        private System.Windows.Forms.GroupBox gbCredenciaisCadastradas;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.ComboBox cmbTipoCredencial;
        private System.Windows.Forms.Label lblTipoCredencial;
    }
}