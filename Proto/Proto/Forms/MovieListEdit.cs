using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Proto.BusinessLogic;

namespace Proto.Forms
{
    public partial class MovieListEdit : Proto.Forms.MovieListBase
    {
        string name;
        public MovieListEdit(string name)
        {
            InitializeComponent();
            this.name = name;
            txtName.Text = name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            MovieListLogic.editMovieList(txtName.Text);

            MessageBox.Show("Renamed");
            Close();
        }

    }
}
