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
    public partial class MovieBase : Form
    {
        public MovieBase()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Graphics Types(.bmp, .jpg, .jpeg, .png, .tif, .tiff|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";
            open.Multiselect = false;
            if(open.ShowDialog() == DialogResult.OK)
            {
                if(open.CheckFileExists)
                {
                    string filename = open.FileName;
                    txtImage.Text = open.SafeFileName;

                    pbPoster.Image = Image.FromFile(filename);
                    pbPoster.SizeMode = PictureBoxSizeMode.StretchImage;

                    cbImage.Checked = true;
                }
            }
        }

        private void btnAddCast_Click(object sender, EventArgs e)
        {
            string txt = txtCast.Text.Trim();
            if(txt.Length > 0)
            {
                if(!lbCast.Items.Contains(txt))
                {
                    lbCast.Items.Add(txt);
                    txtCast.Text = "";
                }
                else
                {
                    MessageBox.Show("This cast is already in the list");
                    // already in the list
                }
            }
        }

        private void btnDeleteCast_Click(object sender, EventArgs e)
        {
            int index = lbCast.SelectedIndex;
            if(index >= 0)
            {
                lbCast.Items.RemoveAt(index);
            }
                /*
            else
            {
                // not selected any
            }
                 */
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void validating_txt(object sender, CancelEventArgs e)
        {
            string err = null;
            if (((TextBox)sender).Text.Trim().Length <= 0 || ((TextBox)sender).Text.Trim().Length > 99)
            {
                err = ((TextBox)sender).AccessibleName + " input is not valid. Enter 1 ~ 99 Characters\n";
            }
            ep.SetError((Control)sender, err);
        }

        private void validating_txtInt(object sender, CancelEventArgs e)
        {
            string err = null;
            if (((TextBox)sender).Text.Trim().Length <= 0 || ((TextBox)sender).Text.Trim().Length > 4)
            {
                err = ((TextBox)sender).AccessibleName + " input is not valid. Enter 1 ~ 4 numbers\n";
            }
            ep.SetError((Control)sender, err);
        }

        private void validating_numKey(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void txtTitle_Enter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            tt.InitialDelay = 0;
            tt.ShowAlways = true;
            tt.SetToolTip((TextBox)sender, "Enter Title here, Max 99 Characters");
        }
        private void txtDirector_Enter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            tt.InitialDelay = 0;
            tt.ShowAlways = true;
            tt.SetToolTip((TextBox)sender, "Enter Director here, Max 99 Characters");
        }
        private void txtCast_Enter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            tt.InitialDelay = 0;
            tt.ShowAlways = true;
            tt.SetToolTip((TextBox)sender, "Enter each cast here, and click Add, Max 99 Characters");
        }
        private void txtLength_Enter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            tt.InitialDelay = 0;
            tt.ShowAlways = true;
            tt.SetToolTip((TextBox)sender, "Enter Running time here, Max 4 digit");
        }
        private void txtYear_Enter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            tt.InitialDelay = 0;
            tt.ShowAlways = true;
            tt.SetToolTip((TextBox)sender, "Enter release year here, Max 4 digit");
        }
        private void Poster_Hover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            tt.InitialDelay = 0;
            tt.ShowAlways = true;
            tt.SetToolTip((PictureBox)sender, "Click Browse to include poster image");
        }
    }
}
