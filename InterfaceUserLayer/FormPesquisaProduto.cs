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
    public partial class frmPesquisaProduto : Form
    {
        ProdutoBLL produtoBLL = new ProdutoBLL();
        public frmPesquisaProduto()
        {
            InitializeComponent();
            this.Load += frmPesquisaDeProduto_Load;
        }

        private void AtualizarGrid()
        {
            DataResponse<Produto> response = produtoBLL.GetAll();
            if (response.Success)
            {
                this.dgvResultadosPesquisa.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void frmPesquisaDeProduto_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Descricao = txtPesquisar.Text;
            DataResponse<Produto> response = produtoBLL.PesquisarProduto(produto);
            if (response.Success)
            {
                this.dgvResultadosPesquisa.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            Produto produto = (Produto)this.dgvResultadosPesquisa.SelectedRows[0].DataBoundItem;
            frmEditProduto fec = new frmEditProduto();
            fec.ShowDialog();
        }
    }
}

