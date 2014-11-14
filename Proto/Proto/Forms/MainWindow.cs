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

            
            DBImplement db = new DBImplement();
            db.getConnection();
            db.saveMovie();
            
            InitializeComponent();
        }

        private void something()
        {
            Movie dummy = new Movie();

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
