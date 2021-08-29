using BusinessLogicalLayer;
using Entities;
using Entities.Enum;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsInterfaceUserLayer
{
    public partial class frmCadastroCredencial : Form
    {
        CredencialBLL credencialBLL = new CredencialBLL();

        public frmCadastroCredencial()
        {
            InitializeComponent();
            this.Load += frmCadastroCredencial_Load;
        }

        private void frmCadastroCredencial_Load(object sender, EventArgs e)
        {
            this.AtualizarGrid();
        }

        private void btnCadastrarSalvar_Click(object sender, EventArgs e)
        {
            Credencial c = new Credencial();
            c.Nome = txtNome.Text;
            c.Email = txtEmail.Text;
            c.Senha = txtSenha.Text;
            c.TipoCredencial = (TipoCredencial)cmbTipoCredencial.SelectedIndex;
            Response response = credencialBLL.Insert(c);
            MessageBox.Show(response.Message);

            if (response.Success)
            {
                FormCleaner.ClearForm(this);
            }
        }

        private void AtualizarGrid()
        {
            DataResponse<Credencial> response = credencialBLL.GetAll();
            if (response.Success)
            {
                this.dgvCredenciaisCadastradas.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Credencial c = (Credencial)dgvCredenciaisCadastradas.SelectedRows[0].DataBoundItem;
            frmEditCredencial fec = new frmEditCredencial(c);
            fec.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.AtualizarGrid();
        }
    }
}
