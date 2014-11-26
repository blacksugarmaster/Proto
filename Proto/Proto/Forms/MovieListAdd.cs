using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Proto.BusinessObject;
using Proto.BusinessLogic;

namespace Proto.Forms
{
    public partial class MovieListAdd : Proto.Forms.MovieListBase
    {
        public MovieListAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // save
            if(txtName.Text.Trim().Length >0)
            {
                if (MovieListLogic.addMovieList(txtName.Text))
                {
                    MessageBox.Show("List " + txtName.Text + " Added");
                    Close();
                }
                else
                {
                    MessageBox.Show("DB error, can't save/add new list");
                }
                
            }
            else
            {
                MessageBox.Show("Need name for new list");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
