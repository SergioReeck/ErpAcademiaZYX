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
    public partial class frmCadastroProfessor : Form
    {
        ProfessorBLL professorBLL = new ProfessorBLL();

        public frmCadastroProfessor()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Professor f = new Professor();
            f.Nome = txtNome.Text;
            f.Email = txtEmail.Text;
            f.RG = txtRG.Text;
            f.CPF = txtCPF.Text;
            f.Telefone = txtTelefone.Text;
            f.DataNascimento = dtpDataNascimento.Value;
            f.Salario = Convert.ToDouble(txtSalario.Text);
            f.Comissao = Convert.ToDouble(txtComissao.Text);
            f.Rua = txtRua.Text;
            f.Numero = txtNumero.Text;
            f.Bairro = txtBairro.Text;
            f.CEP = txtCEP.Text;
            f.Complemento = txtComplemento.Text;
            f.Cidade = txtCidade.Text;
            f.UF = txtUF.Text;

            Response response = professorBLL.Insert(f);
            if (response.Success)
            {
                FormCleaner.ClearForm(this);
            }
            MessageBox.Show(response.Message);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Professor f = new Professor();
            f.Nome = txtNome.Text;
            f.Email = txtEmail.Text;
            f.Telefone = txtTelefone.Text;
            f.Salario = Convert.ToDouble(txtSalario.Text);
            f.Comissao = Convert.ToDouble(txtComissao.Text);
            f.Rua = txtRua.Text;
            f.Numero = txtNumero.Text;
            f.Bairro = txtBairro.Text;
            f.CEP = txtCEP.Text;
            f.Complemento = txtComplemento.Text;
            f.Cidade = txtCidade.Text;
            f.UF = txtUF.Text;

            Response response = professorBLL.Update(f);
            if (response.Success)
            {
                FormCleaner.ClearForm(this);
            }
            MessageBox.Show(response.Message);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmPesquisaProfessor fpf = new frmPesquisaProfessor();
            fpf.ShowDialog();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            FormCleaner.ClearForm(this);
        }
    }
}
