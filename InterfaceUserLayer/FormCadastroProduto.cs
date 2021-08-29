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
    public partial class frmCadastroProduto : Form
    {
        ProdutoBLL produtoBLL = new ProdutoBLL();

        public frmCadastroProduto()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            p.Descricao = txtDescricao.Text;
            p.ValorVenda = (txtValorVenda.Text).ToDouble();
            p.Categoria = (Categoria)cmbCategoria.SelectedIndex;
            Response response = produtoBLL.Insert(p);
            if (response.Success)
            {
                FormCleaner.ClearForm(this);
            }
            MessageBox.Show(response.Message);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto fpp = new frmPesquisaProduto();
            fpp.ShowDialog();
        }
    }
}
