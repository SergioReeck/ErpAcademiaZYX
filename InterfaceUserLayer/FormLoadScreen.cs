using BusinessLogicalLayer;
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
    public partial class frmLoadScreen : Form
    {
        public frmLoadScreen()
        {
            InitializeComponent();
        }

        frmMainScreen fms = new frmMainScreen();

        private void tmProgressBar_Tick(object sender, EventArgs e)
        {
            if (pbSplashScreen.Value < 100)
            {
                pbSplashScreen.Value += 10;
            }
            else
            {
                tmProgressBar.Enabled = false;
                this.Visible = false;
                fms.ShowDialog();
            }
        }
    }
}
