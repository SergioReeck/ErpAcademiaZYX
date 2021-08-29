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
    public partial class frmVendaProduto : Form
    {
        private VendaProdutoBLL vendaDeProdutoBLL = new VendaProdutoBLL();

        private ProdutoBLL produtoBLL = new ProdutoBLL();
        private int idProdutoSelecionado = 0;
        private BindingList<ItemVenda> Items = new BindingList<ItemVenda>();
        private AlunoBLL clienteBLL = new AlunoBLL();


        public frmVendaProduto()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            VendaProduto vendaDeProduto = new VendaProduto();
            vendaDeProduto.Items = this.Items.ToList();
            vendaDeProduto.Cliente = ((Aluno)cmbItens.SelectedItem).ID;

            Response r = vendaDeProdutoBLL.RegistrarVenda(vendaDeProduto);
            MessageBox.Show(r.Message);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Produto p = this.dgvListaProdutoVenda.Rows[e.RowIndex].DataBoundItem as Produto;
            txtProduto.Text = p.Descricao;
            this.idProdutoSelecionado = p.ID;
        }

        private void btnAddItem_Click_1(object sender, EventArgs e)
        {
            ItemVenda item = new ItemVenda();
            item.Quantidade = int.Parse(txtQuantidade.Text);
            item.Valor = double.Parse(txtValor.Text);
            Items.Add(item);
            cmbItens.DataSource = Items;
        }

        private void FormVendaDeProduto_Load(object sender, EventArgs e)
        {
            dgvListaProdutoVenda.DataSource = produtoBLL.GetAll().Data;
            cmbItens.DataSource = clienteBLL.GetAll().Data;
        }
    }
}

