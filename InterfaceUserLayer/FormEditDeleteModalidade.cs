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
    public partial class frmEditDeleteModalidade : Form
    {
        private ModalidadeBLL modalidadeBLL = new ModalidadeBLL();

        public frmEditDeleteModalidade(Modalidade modalidade)
        {
            InitializeComponent();
            this.txtID.Text = modalidade.ID.ToString();
            this.txtDescricao.Text = modalidade.Descricao;
            this.txtValor.Text = Convert.ToString(modalidade.Valor);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Response r = modalidadeBLL.Update(new Modalidade()
            {
                ID = Convert.ToInt32(txtID.Text),
                Descricao = txtDescricao.Text,
                Valor = txtValor.Text.ToDouble()
            });
            MessageBox.Show(r.Message);

            if (r.Success)
            {
                this.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Response r = modalidadeBLL.Delete(Convert.ToInt32(txtID.Text));
            MessageBox.Show(r.Message);
            if (r.Success)
            {
                this.Close();
            }
        }
    }
}
