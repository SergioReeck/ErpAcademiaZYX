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
    public partial class frmEditCredencial : Form
    {
        private CredencialBLL credencialBLL = new CredencialBLL();

        public frmEditCredencial(Credencial credencial)
        {
            InitializeComponent();
            this.txtID.Text = credencial.ID.ToString();
            this.txtNome.Text = credencial.Nome;
            this.txtEmail.Text = credencial.Email;
            this.txtSenha.Text = credencial.Senha;
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Response r = credencialBLL.Update(new Credencial()
            {
                ID = Convert.ToInt32(txtID.Text),
                Nome = txtNome.Text,
                Senha = txtSenha.Text
            });
            MessageBox.Show(r.Message);

            if (r.Success)
            {
                this.Close();
            }
        }
    }
}
