﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proto.DB;

namespace Proto.Forms
{
    public partial class SettingsWindow : Form
    {
        private bool reseted;
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void btnResetDB_Click(object sender, EventArgs e)
        {
            DialogResult reset = MessageBox.Show("This will erase All the current data! Are you sure? (this cannot be undo)",
                "Database Reset?",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if(reset == DialogResult.OK)
            {
                DBImplement.proxy.reset();
                reseted = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(reseted)
            {
                this.DialogResult = DialogResult.Yes;
            }
            
            Close();
        }

        private void btnDefPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog sel = new FolderBrowserDialog();
            if(sel.ShowDialog() == DialogResult.OK)
            {
                string path = sel.SelectedPath;
                DBImplement.proxy.setDefPath(path);
            }
        }
    }
}
