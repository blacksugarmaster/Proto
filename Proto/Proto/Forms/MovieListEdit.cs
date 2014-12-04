using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proto.Forms
{
    public partial class MovieListEdit : Proto.Forms.MovieListBase
    {
        public MovieListEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // save
            MessageBox.Show("Renamed");
            Close();
        }

    }
}
