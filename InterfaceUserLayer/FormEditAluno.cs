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
    public partial class frmEditAluno : Form
    {
        AlunoBLL clienteBLL = new AlunoBLL();

        public frmEditAluno(Aluno cliente)
        {
            InitializeComponent();
            this.txtID.Text = cliente.ID.ToString();
            this.txtNome.Text = cliente.Nome;
            this.txtCPF.Text = cliente.CPF;
            this.txtRG.Text = cliente.RG;
            this.txtEmail.Text = cliente.Email;
            this.dtpDataDeNascimento.Value = cliente.DataNascimento;
            this.dtpDataDaMatricula.Value = cliente.DataMatricula;
            this.txtRua.Text = cliente.Rua;
            this.txtNumero.Text = cliente.Numero;
            this.txtBairro.Text = cliente.Bairro;
            this.txtCidade.Text = cliente.Cidade;
            this.txtCEP.Text = cliente.CEP;
            this.txtComplemento.Text = cliente.Complemento;
            this.txtUF.Text = cliente.UF;
            this.txtTelefone1.Text = cliente.Telefone1;
            this.txtTelefone2.Text = cliente.Telefone2;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Aluno c = new Aluno();
            c.ID = Convert.ToInt32(txtID.Text);
            c.Nome = txtNome.Text;
            c.Email = txtEmail.Text;
            c.Rua = txtRua.Text;
            c.Numero = txtNumero.Text;
            c.Bairro = txtBairro.Text;
            c.Cidade = txtCidade.Text;
            c.CEP = txtCEP.Text;
            c.Complemento = txtComplemento.Text;
            c.UF = txtUF.Text;
            c.Telefone1 = txtTelefone1.Text;
            c.Telefone2 = txtTelefone2.Text;

            Response response = clienteBLL.Update(c);
            if (response.Success)
            {
                this.Close();
            }
            MessageBox.Show(response.Message);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            FormCleaner.ClearForm(this);
        }
    }
}
