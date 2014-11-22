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

namespace Proto
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            connectDB();
            //DBImplement.proxy.reset();
            testDB();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            displayAllMovie();
        }

        private void connectDB()
        {
            try
            {
                DBImplement db = new DBImplement();
                db.getConnection();
                DBImplement.proxy = db;

                DBImplement.proxy.reset();
            }
            catch (Exception e)
            {

            }
        }

        private void displayAllMovie()
        {
            DataTable table = DBImplement.proxy.getAllMovieDT();
            
            // get image name for each row, check if valid
            // add to ImageList ( ImageList . ImageSize parameter )
            // http://www.c-sharpcorner.com/UploadFile/9f4ff8/listview-in-C-Sharp/
        }

        private void testDB()
        {
            List<string> cast = new List<string>();
            cast.Add("cast1");
            cast.Add("cast2");

            Movie dummy = new Movie("new movie!",2014,12,(int)EGenre.Action,"someImage.jpg",cast);
            dummy.save();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }



    }
}
