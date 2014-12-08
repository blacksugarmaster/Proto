using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proto.Forms
{
    public partial class MovieListBase : Form
    {
        public MovieListBase()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void validating_txt(object sender, CancelEventArgs e)
        {
            string err = null;
            if (((TextBox)sender).Text.Trim().Length <= 0 || ((TextBox)sender).Text.Trim().Length > 25 )
            {
                err = "The input is not valid. Enter 1 ~ 25 Characters";
            }
            ep.SetError((Control)sender, err);
        }
        private void txtName_Enter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            tt.InitialDelay = 0;
            tt.ShowAlways = true;
            tt.SetToolTip((TextBox)sender, "Enter list name, Max 25 characters");
        }
    }
}
