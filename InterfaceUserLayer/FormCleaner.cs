using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsInterfaceUserLayer
{
    class FormCleaner
    {
        public static void ClearForm(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item.HasChildren)
                {
                    ClearForm(item);
                }
                if (item is TextBoxBase)
                {
                    item.Text = "";
                }
            }
        }
    }
}
