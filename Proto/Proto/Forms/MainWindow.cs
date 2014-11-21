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
            something();
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

        private void something()
        {
            Movie dummy = new Movie("new movie!",2014,12,(int)EGenre.Action,"someImage.jpg");
            dummy.save();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
