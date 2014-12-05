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

        private bool dpAll = true;

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
            displayMovies(allMovie);
            displayMovieLists();
            lbList.SetSelected(0, true);
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

        private void displayMovieLists()
        {
            List<MovieList> lists = MovieListLogic.getAll();

            foreach(MovieList list in lists)
            {
                lbList.Items.Add(list.name);
            }
        }
        private void displayMovieList(MovieList list)
        {
            lbList.Items.Add(list.name);
        }

        private void displayMovies(MovieList list)
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
        public void displayMovie(Movie mov)
        {
            // display one more movie ( from newly added )
            ImageList ilall = new ImageList();
            ilall.ImageSize = new Size(175, 256);

            string path = defPath + "\\" + mov.imageName;
            if (System.IO.File.Exists(path))
            {
                System.Console.WriteLine(path);
                ilall.Images.Add(mov.id, Image.FromFile(path));
            }
            ListViewItem movie = new ListViewItem();
            movie.Text = mov.title;
            movie.Tag = mov.id;
            movie.ImageKey = mov.id;

            lvMovie.Items.Add(movie);
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

            int length = int.MaxValue;
            if(txtMax.Text.Trim().Length > 0 )
            {
                length = int.Parse(txtMax.Text.Trim());
            }
           
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
            if(cbHorror4.Checked)
            {
                gen.Add(Genre.getString(4));
            }
            if(cbAnimation5.Checked)
            {
                gen.Add(Genre.getString(5));
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
            MovieList res = SearchLogic.search(title, director, cast, gen, rat, length);

            displayMovies(res);
        }
        private void validating_numKey(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(MovieAdd add = new MovieAdd())
            {
                if(add.ShowDialog() == DialogResult.OK)
                {
                    displayMovie(add.NewMovie);
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvMovie.SelectedItems.Count > 0)
            {
                ListViewItem selected = lvMovie.SelectedItems[0];
                Movie movie = DBImplement.proxy.getMovieById(selected.Tag.ToString());
                MovieEdit edit = new MovieEdit(movie);
                edit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Need to select Movie to Edit !");
            }
        }

        private void displayMovieOnPanel(Movie movie)
        {
            lbTitle.Text = movie.title;
            ptxtDirector.Text = movie.director;

            // need to make a string
            string c = "";
            foreach (string cast in movie.cast)
            {
                c += cast + "  ";
            }
            ptxtCast.Text = c;

            string g = "";
            foreach (string genre in movie.genre)
            {
                g += genre + "  ";
            }
            ptxtGenre.Text = g;

            ptxtRating.Text = movie.age;
            if (movie.year != -1)
            {
                ptxtYear.Text = movie.year.ToString();
            }

            ptxtLength.Text = "";
            if (movie.length != -1)
            {
                ptxtLength.Text = movie.length.ToString();
            }

            if (System.IO.File.Exists(defPath + "//" + movie.imageName))
            {
                pbPoster.Image = Image.FromFile(defPath + "//" + movie.imageName);
            }
            else
            {
                pbPoster.Image = null;
            }

            pbPoster.SizeMode = PictureBoxSizeMode.StretchImage;

            pMovieView.Visible = true;



            lvSimilarMovies.Clear();
            MovieList list = SearchLogic.searchSimilarMovies(movie);
            ImageList ilall = new ImageList();
            ilall.ImageSize = new Size(175, 256);

            // add all image to the 'all' imagelist if file exists
            foreach (Movie mov in list)
            {
                string path = defPath + "//" + mov.imageName;
                if (System.IO.File.Exists(path))
                {
                    //System.Console.WriteLine(path);
                    ilall.Images.Add(mov.id, Image.FromFile(path));
                }
            }

            lvSimilarMovies.LargeImageList = ilall;

            foreach (Movie mov in list)
            {
                ListViewItem movieItem = new ListViewItem();
                movieItem.Text = mov.title;
                movieItem.Tag = mov.id;
                movieItem.ImageKey = mov.id;
                lvSimilarMovies.Items.Add(movieItem);
            }
            lvSimilarMovies.View = View.LargeIcon;

        }

        private void lvMovie_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvMovie.SelectedItems.Count > 0)
            {
                ListViewItem selected = lvMovie.SelectedItems[0];
                Movie movie = DBImplement.proxy.getMovieById(selected.Tag.ToString());
                displayMovieOnPanel(movie);
            }
            else
            {
                MessageBox.Show("Need to select to view movie Info");
            }
        }

        private void btnPanelClose_Click(object sender, EventArgs e)
        {
            pMovieView.Visible = false;
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().Show();
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            using (MovieListAdd add = new MovieListAdd())
            {
                if (add.ShowDialog() == DialogResult.OK)
                {
                    displayMovieList(add.NewMovieList);
                }
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(SettingsWindow set = new SettingsWindow())
            {
                if (set.ShowDialog() == DialogResult.Yes)
                {
                    lvMovie.Clear();
                    for(int i = 1 ; i < lbList.Items.Count ; i ++)
                    {
                        lbList.Items.RemoveAt(i);
                    }
                }
            }
        }

        private void btnDeleteList_Click(object sender, EventArgs e)
        {
            if(lbList.SelectedItems.Count > 0)
            {
                string name = lbList.GetItemText(lbList.SelectedItem);

                if (!name.Equals("All"))
                {
                    MovieListLogic.deleteMovieList(name);
                    lbList.Items.RemoveAt(lbList.Items.IndexOf(name));
                    MessageBox.Show("List Deleted");
                }
                else
                {
                    MessageBox.Show("Cannot delete Default list", "Default List", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnRenameList_Click(object sender, EventArgs e)
        {
            if(lbList.SelectedItems.Count > 0)
            {
                string name = lbList.GetItemText(lbList.SelectedItem);
                if(!name.Equals("All"))
                {
                    using (MovieListRename rename = new MovieListRename(name))
                    {
                        if (rename.ShowDialog() == DialogResult.OK)
                        {
                            lbList.Items.Insert(lbList.Items.IndexOf(name), rename.NewName);
                            lbList.Items.RemoveAt(lbList.Items.IndexOf(name));
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cannot renames Default list", "Default List", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbList.SelectedItems.Count > 0)
            {
                string name = lbList.GetItemText(lbList.SelectedItem);
                MovieList list = DBImplement.proxy.getMovieListByName(name);
                displayMovies(list);

                if(!name.Equals("All"))
                {
                    dpAll = false;
                }
                
            }
        }

        private void dynamicAddItems(object sender, EventArgs e)
        {
            cmsMovieAdd.Items[0].Visible = dpAll;
            cmsMovieAdd.Items[1].Visible = !dpAll;

            if (lvMovie.SelectedItems.Count > 0)
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
            if(lvMovie.SelectedItems.Count > 0)
            {
                MovieListLogic.addMovie(selected.Name, lvMovie.SelectedItems[0].Tag.ToString());
            }
        }

        private void removeFromThisListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lbList.SelectedItems.Count > 0 && lvMovie.SelectedItems.Count > 0)
            {
                MovieListLogic.deleteMovie(lbList.SelectedItems[0].ToString(), lvMovie.SelectedItems[0].Tag.ToString());
            }
        }

        private void lvMovie_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                // only one left click can start draggin event.

                if (lvMovie.Items.Count <= 0)
                {
                    return;
                }

                ListViewItem selected = lvMovie.GetItemAt(e.X, e.Y);
                if (selected != null)
                {
                    string id = selected.Tag.ToString(); // it is id of the movie
                    DragDropEffects ef = DoDragDrop(id, DragDropEffects.Copy);

                    if (ef == DragDropEffects.Copy)
                    {
                        // can change cursor
                        // poster image etc..
                    }
                }
            }
            else if(e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                // it is not drag start event.
                // if double clicked, have to display detail info

                lvMovie_MouseDoubleClick(sender, e);
            }
        }

        private void lbList_DragDrop(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string id = (string)e.Data.GetData(DataFormats.StringFormat);

                Point p = lbList.PointToClient(Cursor.Position);
                int index = lbList.IndexFromPoint(p);
                if (index < 0)
                {
                    return;
                }

                int old = lbList.SelectedIndex;

                lbList.SetSelected(index,true);
                lbList.SetSelected(old, true);

                MovieListLogic.addMovie(lbList.Items[index].ToString(), id);
            }
        }

        private void lbList_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void lvSimilarMovies_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvSimilarMovies.SelectedItems.Count > 0)
            {
                ListViewItem selected = lvSimilarMovies.SelectedItems[0];
                Movie movie = DBImplement.proxy.getMovieById(selected.Tag.ToString());
                
                displayMovieOnPanel(movie);
            }
            else
            {
                MessageBox.Show("Need to select to view movie Info");
            }
        }
    }
}
