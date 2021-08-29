using BusinessLogicalLayer;
using Entities;
using WinFormsInterfaceUserLayer;
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
    public partial class frmLoginScreen : Form
    {
        public frmLoginScreen()
        {
            InitializeComponent();
            this.txtUsuario.Text = "administracao@academiazyx.com.br";
            this.txtSenha.Text = "Admin12345";
        }

        CredencialBLL credencialBLL = new CredencialBLL();

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            SingleResponse<Credencial> response = credencialBLL.Authenticate(txtUsuario.Text, txtSenha.Text);

            if (response.Success)
            {
                frmLoadScreen fsc = new frmLoadScreen();
                this.Visible = false;
                fsc.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {
            FormCleaner.ClearForm(this);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
