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
        private static bool testDB = false;

        private MovieList allMovie = null;
        private string defPath;

        public MainWindow()
        {
            InitializeComponent();
            connectDB();

            if(testDB)
            {
                DBtest.testAddMovie();
            }

        }

        private static void DBReset()
        {
            DBImplement.proxy.reset();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            allMovie = MovieLogic.getAll();
            displayMovie(allMovie);
            displayMovieList();
        }

        private void connectDB()
        {
            try
            {
                DBImplement db = new DBImplement();
                db.getConnection();
                DBImplement.proxy = db;
                defPath = DBImplement.proxy.getDefPath();
            }
            catch (Exception e)
            {

            }
        }

        private void displayMovieList()
        {
            List<MovieList> lists = MovieListLogic.getAll();

            foreach(MovieList list in lists)
            {
                lbList.Items.Add(list.name);
            }
        }

        private void displayMovie(MovieList list)
        {
            // display any movielist on lvMovie ( ListView )

            lvMovie.Clear();

            ImageList ilall = new ImageList();
            ilall.ImageSize = new Size(175, 256);

            // add all image to the 'all' imagelist if file exists
            foreach (Movie mov in list)
            {
                string path = defPath + "//"+ mov.imageName;
                if (System.IO.File.Exists(path))
                {
                    //System.Console.WriteLine(path);
                    ilall.Images.Add(mov.id,Image.FromFile(path));
                }
            }

            lvMovie.LargeImageList = ilall;

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

            string title = txtTitle.Text.Trim();
            string director = txtDirector.Text.Trim();
            string cast = txtCast.Text.Trim();

            List<string> gen = new List<string>();

            //genre
            if (cbSciFi0.Checked)
            {
                gen.Add(Genre.getString(0));
            }
            if (cbDrama1.Checked)
            {
                gen.Add(Genre.getString(1));
            }
            if (cbAction2.Checked)
            {
                gen.Add(Genre.getString(2));
            }
            if (cbThriller3.Checked)
            {
                gen.Add(Genre.getString(3));
            }

            List<string> rat = new List<string>();
            //rating
            if (cbG.Checked)
            {
                rat.Add("G");
            }
            if (cbPG.Checked)
            {
                rat.Add("PG");
            }
            if (cbPG13.Checked)
            {
                rat.Add("PG13");
            }
            if (cbR.Checked)
            {
                rat.Add("R");
            }
            if (cbNC17.Checked)
            {
                rat.Add("NC17");
            }


            MovieList res = SearchLogic.search(title, director, cast, gen, rat);

            displayMovie(res);
        }


        private void search()
        {
            string title = txtTitle.Text.Trim();
            string director = txtDirector.Text.Trim();
            string cast = txtCast.Text.Trim();

            List<string> gen = new List<string>();

            //genre
            if (cbSciFi0.Checked)
            {
                gen.Add(Genre.getString(0));
            }
            if (cbDrama1.Checked)
            {
                gen.Add(Genre.getString(1));
            }
            if (cbAction2.Checked)
            {
                gen.Add(Genre.getString(2));
            }
            if (cbThriller3.Checked)
            {
                gen.Add(Genre.getString(3));
            }

            List<string> rat = new List<string>();
            //rating
            if (cbG.Checked)
            {
                rat.Add("G");
            }
            if (cbPG.Checked)
            {
                rat.Add("PG");
            }
            if (cbPG13.Checked)
            {
                rat.Add("PG13");
            }
            if (cbR.Checked)
            {
                rat.Add("R");
            }
            if (cbNC17.Checked)
            {
                rat.Add("NC17");
            }


            MovieList res = SearchLogic.search(title, director, cast, gen, rat);

            displayMovie(res);

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
                

                if(System.IO.File.Exists(movie.imageName))
                {
                    pbPoster.Image = Image.FromFile(movie.imageName);
                }
                
                pbPoster.SizeMode = PictureBoxSizeMode.StretchImage;

                pMovieView.Visible = true;

            }
            else
            {
                MessageBox.Show("Need to select Movie to Edit !");
            }
            

        }


        private void btnPanelClose_Click(object sender, EventArgs e)
        {
            pMovieView.Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lvMovie.Clear();
            displayMovie(DBImplement.proxy.getAllMovie());
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().Show();
        }

        private void listAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MovieListAdd().Show();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string name = lbList.GetItemText(lbList.SelectedItem);
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            new MovieListAdd().Show();
        }



        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SettingsWindow().Show();
        }

        private void btnDeleteList_Click(object sender, EventArgs e)
        {
            string name = lbList.GetItemText(lbList.SelectedItem);
            MovieListLogic.deleteMovieList(name);
            MessageBox.Show("List Deleted");
        }

        private void btnRenameList_Click(object sender, EventArgs e)
        {
            string name = lbList.GetItemText(lbList.SelectedItem);
            new MovieListRename(name).Show();
        }

        private void lbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbList.SelectedItems.Count > 0)
            {
                string name = lbList.GetItemText(lbList.SelectedItem);
                MovieList list = DBImplement.proxy.getMovieListByName(name);
                displayMovie(list);
            }
        }

        private void dynamicAddItems(object sender, EventArgs e)
        {
            if(lvMovie.SelectedItems.Count > 0)
            {
                ListBox.ObjectCollection lists = lbList.Items;
                ToolStripMenuItem[] items = new ToolStripMenuItem[lists.Count];
                for (int i = 0; i < lists.Count; i++)
                {
                    items[i] = new ToolStripMenuItem();
                    items[i].Name = lists[i].ToString();
                    items[i].Text = lists[i].ToString();
                    items[i].Click += new EventHandler(AddtoListHandler);
                }
                this.addToAListToolStripMenuItem.DropDownItems.Clear();
                this.addToAListToolStripMenuItem.DropDownItems.AddRange(items);

            }

        }

        private void AddtoListHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem selected = (ToolStripMenuItem)sender;
            MovieListLogic.addMovie(selected.Name, lvMovie.SelectedItems[0].Tag.ToString());
        }


    }
}
