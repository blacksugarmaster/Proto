using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Proto.BusinessObject;
using Proto.BusinessLogic;
using System.Linq;

namespace Proto.Forms
{
    public partial class MovieEdit : Proto.Forms.MovieBase
    {
        Movie movie;
        public MovieEdit(Movie m)
        {
            InitializeComponent();
            movie = m;
            txtTitle.Text = movie.title;
            txtDirector.Text = movie.director;

            if(movie.year != -1)
            {
                txtYear.Text = movie.year.ToString();
            }

            txtImage.Text = movie.imageName;
            if(movie.imageName.Trim().Length > 0)
            {
                cbImage.Checked = true;
            }

            foreach(string c in movie.cast)
            {
                lbCast.Items.Add(c);
            }

            // parse genre
            foreach(string g in movie.genre)
            {
                if(g.Equals("SciFi"))
                {
                    cbSciFi0.Checked = true;
                }
                if(g.Equals("Drama"))
                {
                    cbDrama1.Checked = true;
                }
                if(g.Equals("Action"))
                {
                    cbAction2.Checked = true;
                }
                if(g.Equals("Thriller"))
                {
                    cbThriller3.Checked = true;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> cast = lbCast.Items.OfType<string>().ToList();
            List<string> genre = new List<string>();

            // parse genre
            if (cbSciFi0.Checked)
            {
                genre.Add(Genre.getString(0));
            }
            if (cbDrama1.Checked)
            {
                genre.Add(Genre.getString(1));
            }
            if (cbAction2.Checked)
            {
                genre.Add(Genre.getString(2));
            }
            if (cbThriller3.Checked)
            {
                genre.Add(Genre.getString(3));
            }

            string age = "";
            // parse rating(age)
            if (rbG.Checked)
            {
                age = "G";
            }
            else if (rbPG.Checked)
            {
                age = "PG";
            }
            else if (rbPG13.Checked)
            {
                age = "PG13";
            }
            else if (rbR.Checked)
            {
                age = "R";
            }
            else if (rbNC17.Checked)
            {
                age = "NC17";
            }

            string image = "";
            // check image include
            if (cbImage.Checked)
            {
                image = txtImage.Text;
            }

            MovieLogic.updateMovie(movie.id,txtTitle.Text, txtDirector.Text, txtYear.Text, age, genre, image, cast);


            MessageBox.Show("Movie Edited");
            // form close ( or add more later )
            this.Close();
        }
    }
}
