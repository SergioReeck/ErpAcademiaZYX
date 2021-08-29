using BusinessLogicalLayer;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsInterfaceUserLayer;

namespace WinFormsInterfaceUserLayer
{
    public partial class frmCadastroAluno : Form
    {
        public frmCadastroAluno()
        {
            InitializeComponent();
        }

        AlunoBLL alunoBLL = new AlunoBLL();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Aluno c = new Aluno();
            c.Nome = txtNome.Text;
            c.Email = txtEmail.Text;
            c.RG = txtRG.Text;
            c.CPF = txtCPF.Text;
            c.Telefone1 = txtTelefone1.Text;
            c.Telefone2 = txtTelefone2.Text;
            c.DataNascimento = dtpDataNascimento.Value;
            c.DataMatricula = dtpDataMatricula.Value;
            c.Rua = txtRua.Text;
            c.Numero = txtNumero.Text;
            c.Bairro = txtBairro.Text;
            c.CEP = txtCEP.Text;
            c.Complemento = txtComplemento.Text;
            c.Cidade = txtCidade.Text;
            c.UF = txtUF.Text;

            Response response = alunoBLL.Insert(c);
            if (response.Success)
            {
                FormCleaner.ClearForm(this);
            }
            MessageBox.Show(response.Message);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmPesquisaAluno fpc = new frmPesquisaAluno();
            fpc.ShowDialog();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            FormCleaner.ClearForm(this);
        }
    }
}
