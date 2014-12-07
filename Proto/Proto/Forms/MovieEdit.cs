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

            if(movie.length != -1)
            {
                txtLength.Text = movie.length.ToString();
            }
            
            // parse genre

            if(movie.genre.Contains(Genre.getString(0)))
            {
                cbSciFi0.Checked = true;
            }
            if(movie.genre.Contains(Genre.getString(1)))
            {
                cbDrama1.Checked = true;
            }
            if(movie.genre.Contains(Genre.getString(2)))
            {
                cbAction2.Checked = true;
            }
            if(movie.genre.Contains(Genre.getString(3)))
            {
                cbThriller3.Checked = true;
            }
            if(movie.genre.Contains(Genre.getString(4)))
            {
                cbHorror4.Checked = true;
            }
            if(movie.genre.Contains(Genre.getString(5)))
            {
                cbAnimation5.Checked = true;
            }


            if (movie.age.Equals("G"))
            {
                rbG.Checked = true;
            }
            else if (movie.age.Equals("PG"))
            {
                rbPG.Checked = true;
            }
            else if (movie.age.Equals("PG13"))
            {
                rbPG13.Checked = true;
            }
            else if (movie.age.Equals("R"))
            {
                rbR.Checked = true;
            }
            else
            {
                rbNC17.Checked = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string eTitle = ep.GetError(txtTitle);
            string eDirector = ep.GetError(txtDirector);
            string eLength = ep.GetError(txtLength);
            string eYear = ep.GetError(txtYear);

            string saveError = eTitle + eDirector + eLength + eYear;

            if(!string.IsNullOrWhiteSpace(saveError.Trim()) )
            {
                MessageBox.Show(saveError);
                return;
            }
            else
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
            if (cbHorror4.Checked)
            {
                genre.Add(Genre.getString(4));
            }
            if (cbAnimation5.Checked)
            {
                genre.Add(Genre.getString(5));
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
}
