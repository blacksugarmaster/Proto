using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Proto.BusinessObject;

namespace Proto.Forms
{
    public partial class MovieEdit : Proto.Forms.MovieBase
    {
        public MovieEdit(Movie movie)
        {
            InitializeComponent();

            txtTitle.Text = movie.title;
            txtDirector.Text = movie.director;
            txtYear.Text = movie.year.ToString();
            txtImage.Text = movie.imageName;
            lbCast.DataSource = movie.cast;
            // parse genre

            foreach(string g in movie.genre)
            {
                if(g.Equals("SciFi"))
                {
                    cbSciFi.Checked = true;
                }
                if(g.Equals("Drama"))
                {
                    cbDrama.Checked = true;
                }
                if(g.Equals("Action"))
                {
                    cbAction.Checked = true;
                }
                if(g.Equals("Thriller"))
                {
                    cbThriller.Checked = true;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
