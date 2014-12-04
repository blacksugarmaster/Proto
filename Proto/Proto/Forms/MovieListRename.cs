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
    public partial class MovieListRename : Proto.Forms.MovieListBase
    {
        string name;
        public MovieListRename(string name)
        {
            InitializeComponent();
            this.name = name;
            txtName.Text = name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MovieListLogic.renameMovieList(name,txtName.Text);

            MessageBox.Show("Renamed");
            Close();
        }

    }
}
