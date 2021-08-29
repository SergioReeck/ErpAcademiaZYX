using BusinessLogicalLayer;
using WinFormsInterfaceUserLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Entities.Enum;

namespace WinFormsInterfaceUserLayer
{
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
            this.sslNomeUsuario.Text = SystemParameters.GetCurrrentCredencial().Nome;
            this.sslDateTime.Text = DateTime.Now.ToString();
            this.Load += frmMainScreen_Load;
        }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            TipoCredencial tipoCredencial = SystemParameters.GetCurrrentCredencial().TipoCredencial;

            switch (tipoCredencial)
            {
                case TipoCredencial.Recepção:
                    this.mnCadastroClientes.Visible = false;
                    this.mnCadastroFuncionarios.Visible = false;
                    this.mnCadastroCredenciais.Visible = false;
                    this.mnCadastroFormasPagamento.Visible = false;
                    this.mnCadastroModalidades.Visible = false;
                    break;
                case TipoCredencial.Professor:
                    this.mnCadastroCredenciais.Visible = false;
                    this.mnCadastroFormasPagamento.Visible = false;
                    this.mnCadastroFuncionarios.Visible = false;
                    this.mnCadastroModalidades.Visible = false;
                    this.mnCadastroProdutos.Visible = false;
                    this.mnEstoque.Visible = false;
                    this.mnPedidos.Visible = false;
                    break;
            }
        }

        private void mnSairSistema_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult response = MessageBox.Show("Deseja mesmo sair do sistema?", " ", MessageBoxButtons.YesNo);

            if (response == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void mnCadastroFormasPagamento_Click(object sender, EventArgs e)
        {
            frmCadastroFormaPagamento fcf = new frmCadastroFormaPagamento();
            fcf.ShowDialog();
        }

        private void mnCadastroFuncionarios_Click(object sender, EventArgs e)
        {
            frmCadastroProfessor fcf = new frmCadastroProfessor();
            fcf.ShowDialog();
        }

        private void mnCadastroModalidades_Click(object sender, EventArgs e)
        {
            frmCadastroModalidade fcm = new frmCadastroModalidade();
            fcm.ShowDialog();
        }

        private void mnCadastroCredenciais_Click(object sender, EventArgs e)
        {
            frmCadastroCredencial fcc = new frmCadastroCredencial();
            fcc.ShowDialog();
        }

        private void mnCadastroClientes_Click(object sender, EventArgs e)
        {
            frmCadastroAluno fcc = new frmCadastroAluno();
            fcc.ShowDialog();
        }

        private void mnCadastroProdutos_Click(object sender, EventArgs e)
        {
            frmCadastroProduto fcp = new frmCadastroProduto();
            fcp.ShowDialog();
        }

        private void mnEntradaProdutos_Click(object sender, EventArgs e)
        {
            frmEntradaProduto fep = new frmEntradaProduto();
            fep.ShowDialog();
        }

        private void mnRealizarVenda_Click(object sender, EventArgs e)
        {
            frmVendaProduto fvp = new frmVendaProduto();
            fvp.ShowDialog();
        }
    }
}
