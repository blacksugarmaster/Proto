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


    }
}
