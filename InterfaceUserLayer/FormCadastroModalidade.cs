using BusinessLogicalLayer;
using Entities;
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
    public partial class frmCadastroModalidade : Form
    {
        ModalidadeBLL modalidadeBLL = new ModalidadeBLL();

        public frmCadastroModalidade()
        {
            InitializeComponent();
            this.Load += FormCadastroDeModalidade_Load;
            this.dgvModalidadesCadastradas.RowsAdded += DgvModalidadesCadastradas_RowsAdded;
        }

        private void DgvModalidadesCadastradas_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.dgvModalidadesCadastradas.Rows[e.RowIndex].Cells[2].Style.Format = "C2";
        }

        private void AtualizarGrid()
        {
            DataResponse<Modalidade> response = modalidadeBLL.GetAll();
            if (response.Success)
            {
                this.dgvModalidadesCadastradas.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void FormCadastroDeModalidade_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnCadastrarSalvar_Click(object sender, EventArgs e)
        {
            Modalidade m = new Modalidade();
            m.Descricao = txtDescricao.Text;
            m.Valor = (txtValor.Text).ToDouble();
            Response response = modalidadeBLL.Insert(m);
            if (response.Success)
            {
                FormCleaner.ClearForm(this);
            }
            MessageBox.Show(response.Message);
            this.AtualizarGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Modalidade m = (Modalidade)dgvModalidadesCadastradas.SelectedRows[0].DataBoundItem;
            frmEditDeleteModalidade fed = new frmEditDeleteModalidade(m);
            fed.ShowDialog();
            this.AtualizarGrid();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }
    }
}
