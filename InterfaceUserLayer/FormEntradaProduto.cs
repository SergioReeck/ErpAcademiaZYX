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
    public partial class frmEntradaProduto : Form
    {
        private EntradaProdutoBLL entradaBLL = new EntradaProdutoBLL();

        private ProdutoBLL produtoBLL = new ProdutoBLL();
        private int idProdutoSelecionado = 0;
        private BindingList<ItemEntrada> Items = new BindingList<ItemEntrada>();

        public frmEntradaProduto()
        {
            InitializeComponent();
        }

        private void FormEntradaDeProduto_Load(object sender, EventArgs e)
        {
            dgvListaProdutosEntrada.DataSource = produtoBLL.GetAll().Data;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Produto p = this.dgvListaProdutosEntrada.Rows[e.RowIndex].DataBoundItem as Produto;
            txtProduto.Text = p.Descricao;
            this.idProdutoSelecionado = p.ID;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            EntradaProduto entrada = new EntradaProduto();
            entrada.Items = this.Items.ToList();

            Response r = entradaBLL.RegistrarEntrada(entrada);
            MessageBox.Show(r.Message);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ItemEntrada item = new ItemEntrada();
            item.Quantidade = int.Parse(txtQuantidade.Text);
            item.Valor = double.Parse(txtValor.Text);
            Items.Add(item);
            cmbItens.DataSource = Items;
        }
    }
}
