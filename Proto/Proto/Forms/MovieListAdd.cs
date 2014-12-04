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

        private MovieList newMovieList;
        public MovieList NewMovieList
        {
            get { return newMovieList; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // save
            if (txtName.Text.Trim().Length > 0)
            {
                MovieList ml = MovieListLogic.addMovieList(txtName.Text);
                if (ml != null)
                {
                    MessageBox.Show("List " + txtName.Text + " Added");
                    newMovieList = ml;
                    this.DialogResult = DialogResult.OK;
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

    }
}
