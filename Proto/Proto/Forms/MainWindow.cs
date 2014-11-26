using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proto.DB;
using Proto.BusinessObject;
using Proto.BusinessLogic;
using Proto.Forms;

namespace Proto
{
    public partial class MainWindow : Form
    {
        private bool testDB = false;

        public MainWindow()
        {
            InitializeComponent();
            connectDB();
            //DBImplement.proxy.reset();

            if(testDB)
            {
                DBtest.testAddMovie();
            }

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            displayMovie(DBImplement.proxy.getAllMovie());
        }

        private void connectDB()
        {
            try
            {
                DBImplement db = new DBImplement();
                db.getConnection();
                DBImplement.proxy = db;
            }
            catch (Exception e)
            {

            }
        }

        private void displayMovie(MovieList list)
        {
            // get image name for each row, check if valid
            // add to ImageList ( ImageList . ImageSize parameter )
            // http://www.c-sharpcorner.com/UploadFile/9f4ff8/listview-in-C-Sharp/

            ImageList ilall = new ImageList();
            ilall.ImageSize = new Size(185, 256);

            // add all image to the 'all' imagelist if file exists
            foreach (Movie mov in list)
            {
                string path = mov.imageName;
                if (System.IO.File.Exists(path))
                {
                    System.Console.WriteLine(path);
                    ilall.Images.Add(mov.id,Image.FromFile(path));
                }
            }

            lvMovie.LargeImageList = ilall;
            int i = 0;
            foreach (Movie mov in list)
            {
                ListViewItem movie = new ListViewItem();
                movie.Text = mov.title;
                movie.Tag = mov.id;
                movie.ImageKey = mov.id;
                lvMovie.Items.Add(movie);

            }
            lvMovie.View = View.LargeIcon;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovieAdd add = new MovieAdd();
            add.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvMovie.SelectedItems.Count > 0)
            {
                ListViewItem selected = lvMovie.SelectedItems[0];
                Movie movie = DBImplement.proxy.getMovieById(selected.Tag.ToString());
                MovieEdit edit = new MovieEdit(movie);
                edit.Show();
            }
            else
            {
                MessageBox.Show("Need to select Movie to Edit !");
            }
            
        }

        private void lvMovie_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvMovie.SelectedItems.Count > 0)
            {
                ListViewItem selected = lvMovie.SelectedItems[0];
                Movie movie = DBImplement.proxy.getMovieById(selected.Tag.ToString());

                lbTitle.Text = movie.title;
                ptxtDirector.Text = movie.director;

                // need to make a string
                string c = "";
                foreach(string cast in movie.cast)
                {
                    c += cast + "  ";
                }
                ptxtCast.Text = c;

                string g = "";
                foreach(string genre in movie.genre)
                {
                    g += genre + "  ";
                }
                ptxtGenre.Text = g;



                ptxtRating.Text = movie.age;
                if (movie.year != -1)
                {
                    ptxtYear.Text = movie.year.ToString();
                }
                

                pbPoster.Image = Image.FromFile(movie.imageName);
                pbPoster.SizeMode = PictureBoxSizeMode.StretchImage;

                pMovieView.Visible = true;

                pOverlay.BackColor = Color.FromArgb(40, 88,44,55);
                pOverlay.Visible = true;
            }
            else
            {
                MessageBox.Show("Need to select Movie to Edit !");
            }
            

        }

        private Size ScaleSize(Size from, int? maxWidth, int? maxHeight)
        {
            if (!maxWidth.HasValue && !maxHeight.HasValue) throw new ArgumentException("At least one scale factor (toWidth or toHeight) must not be null.");
            if (from.Height == 0 || from.Width == 0) throw new ArgumentException("Cannot scale size from zero.");

            double? widthScale = null;
            double? heightScale = null;

            if (maxWidth.HasValue)
            {
                widthScale = maxWidth.Value / (double)from.Width;
            }
            if (maxHeight.HasValue)
            {
                heightScale = maxHeight.Value / (double)from.Height;
            }

            double scale = Math.Min((double)(widthScale ?? heightScale),
                                     (double)(heightScale ?? widthScale));

            return new Size((int)Math.Floor(from.Width * scale), (int)Math.Ceiling(from.Height * scale));
        }

        private void btnPanelClose_Click(object sender, EventArgs e)
        {
            pMovieView.Visible = false;
            pOverlay.Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lvMovie.Clear();
            displayMovie(DBImplement.proxy.getAllMovie());
        }


    }
}
