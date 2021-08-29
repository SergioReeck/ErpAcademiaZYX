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
    public partial class frmEditProfessores : Form
    {
        private ProfessorBLL funcionarioBLL = new ProfessorBLL();

        public frmEditProfessores(Professor funcionario)
        {
            InitializeComponent();
            this.txtID.Text = funcionario.ID.ToString();
            this.txtNome.Text = funcionario.Nome;
            this.txtCPF.Text = funcionario.CPF;
            this.txtRG.Text = funcionario.RG;
            this.txtEmail.Text = funcionario.Email;
            this.dtpDataNascimento.Value = funcionario.DataNascimento;
            this.txtRua.Text = funcionario.Rua;
            this.txtNumero.Text = funcionario.Numero;
            this.txtBairro.Text = funcionario.Bairro;
            this.txtCidade.Text = funcionario.Cidade;
            this.txtCEP.Text = funcionario.CEP;
            this.txtComplemento.Text = funcionario.Complemento;
            this.txtUF.Text = funcionario.UF;
            this.txtTelefone.Text = funcionario.Telefone;
            this.txtSalario.Text = funcionario.Salario.ToString();
            this.txtComissao.Text = funcionario.Comissao.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Professor f = new Professor();
            f.ID = Convert.ToInt32(txtID.Text);
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

            Response response = funcionarioBLL.Update(f);
            if (response.Success)
            {
                FormCleaner.ClearForm(this);
            }
            MessageBox.Show(response.Message);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            FormCleaner.ClearForm(this);
        }
    }
}
