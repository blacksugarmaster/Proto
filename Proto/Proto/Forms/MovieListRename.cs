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
        private string newName;
        public string NewName
        {
            get { return newName; }
        }

        string name;
        public MovieListRename(string name)
        {
            InitializeComponent();
            this.name = name;
            txtName.Text = name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtName.Text))
            {
                MovieListLogic.renameMovieList(name, txtName.Text);

                newName = txtName.Text;
                MessageBox.Show("Renamed");
                this.DialogResult = DialogResult.OK;
                Close();
            }

        }

    }
}
