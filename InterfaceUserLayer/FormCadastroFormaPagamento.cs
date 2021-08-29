using BusinessLogicalLayer;
using Entities;
using WinFormsInterfaceUserLayer;
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
    public partial class frmCadastroFormaPagamento : Form
    {
        private FormaPagamentoBLL formaDePagamentoBLL = new FormaPagamentoBLL();

        public frmCadastroFormaPagamento()
        {
            InitializeComponent();
            this.Load += frmCadastroDeFormaDePagamento_Load;
        }

        private void frmCadastroDeFormaDePagamento_Load(object sender, EventArgs e)
        {
            this.AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            DataResponse<FormaPagamento> response = formaDePagamentoBLL.GetAll();
            if (response.Success)
            {
                this.dgvFormasDePagamentoCadastradas.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void btnCadastrarSalvar_Click(object sender, EventArgs e)
        {
            FormaPagamento fdp = new FormaPagamento();
            fdp.Descricao = txtDescricao.Text;
            Response response = formaDePagamentoBLL.Insert(fdp);
            MessageBox.Show(response.Message);

            if (response.Success)
            {
                FormCleaner.ClearForm(this);
                this.AtualizarGrid();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormaPagamento fdp = (FormaPagamento)dgvFormasDePagamentoCadastradas.SelectedRows[0].DataBoundItem;
            frmEditFormaDePagamento fed = new frmEditFormaDePagamento(fdp);
            fed.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.AtualizarGrid();
        }
    }
}
