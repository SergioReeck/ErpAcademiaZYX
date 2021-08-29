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
    public partial class frmEditFormaDePagamento : Form
    {
        private FormaPagamentoBLL formaDePagamentoBLL = new FormaPagamentoBLL();

        public frmEditFormaDePagamento(FormaPagamento formaDePagamento)
        {
            InitializeComponent();
            this.txtID.Text =  formaDePagamento.ID.ToString();
            this.txtDescricao.Text = formaDePagamento.Descricao;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Response r = formaDePagamentoBLL.Update(new FormaPagamento()
            {
                ID = Convert.ToInt32(txtID.Text),
                Descricao = txtDescricao.Text
            });
            MessageBox.Show(r.Message);

            if (r.Success)
            {
                this.Close();
            }
        }
    }
}
