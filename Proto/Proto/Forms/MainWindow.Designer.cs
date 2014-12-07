namespace Proto
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            //DB.DBImplement.proxy.closeDB();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MovieList = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteList = new System.Windows.Forms.Button();
            this.btnRenameList = new System.Windows.Forms.Button();
            this.btnAddList = new System.Windows.Forms.Button();
            this.lbList = new System.Windows.Forms.ListBox();
            this.cmsMovieList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addAListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Search = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbNC17 = new System.Windows.Forms.CheckBox();
            this.cbR = new System.Windows.Forms.CheckBox();
            this.cbPG13 = new System.Windows.Forms.CheckBox();
            this.cbPG = new System.Windows.Forms.CheckBox();
            this.cbG = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAnimation5 = new System.Windows.Forms.CheckBox();
            this.cbHorror4 = new System.Windows.Forms.CheckBox();
            this.cbSciFi0 = new System.Windows.Forms.CheckBox();
            this.cbThriller3 = new System.Windows.Forms.CheckBox();
            this.cbDrama1 = new System.Windows.Forms.CheckBox();
            this.cbAction2 = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCast = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pMovieView = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ptxtLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ptxtRating = new System.Windows.Forms.TextBox();
            this.ptxtYear = new System.Windows.Forms.TextBox();
            this.ptxtGenre = new System.Windows.Forms.TextBox();
            this.ptxtCast = new System.Windows.Forms.TextBox();
            this.ptxtDirector = new System.Windows.Forms.TextBox();
            this.lbRating = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.lbCast = new System.Windows.Forms.Label();
            this.lbDirector = new System.Windows.Forms.Label();
            this.pTrailer = new System.Windows.Forms.Panel();
            this.btnPanelClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ptxtTitle = new System.Windows.Forms.TextBox();
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lvSimilarMovies = new System.Windows.Forms.ListView();
            this.lvMovie = new System.Windows.Forms.ListView();
            this.cmsMovieAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToAListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFromThisListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.MovieList.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cmsMovieList.SuspendLayout();
            this.Search.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pMovieView.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.panel2.SuspendLayout();
            this.cmsMovieAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.movieToolStripMenuItem,
            this.movieListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1650, 43);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(153, 39);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(178, 40);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(178, 40);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(178, 40);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // movieToolStripMenuItem
            // 
            this.movieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.movieToolStripMenuItem.Name = "movieToolStripMenuItem";
            this.movieToolStripMenuItem.Size = new System.Drawing.Size(95, 39);
            this.movieToolStripMenuItem.Text = "Movie";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(161, 40);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(161, 40);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(161, 40);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // movieListToolStripMenuItem
            // 
            this.movieListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listAddToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.movieListToolStripMenuItem.Name = "movieListToolStripMenuItem";
            this.movieListToolStripMenuItem.Size = new System.Drawing.Size(139, 39);
            this.movieListToolStripMenuItem.Text = "Movie List";
            // 
            // listAddToolStripMenuItem
            // 
            this.listAddToolStripMenuItem.Name = "listAddToolStripMenuItem";
            this.listAddToolStripMenuItem.Size = new System.Drawing.Size(180, 40);
            this.listAddToolStripMenuItem.Text = "Add";
            this.listAddToolStripMenuItem.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(180, 40);
            this.editToolStripMenuItem1.Text = "Rename";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.btnRenameList_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(180, 40);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.btnDeleteList_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 43);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pMovieView);
            this.splitContainer1.Panel2.Controls.Add(this.lvMovie);
            this.splitContainer1.Panel2.Controls.Add(this.txtCount);
            this.splitContainer1.Size = new System.Drawing.Size(1650, 1065);
            this.splitContainer1.SplitterDistance = 550;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MovieList);
            this.tabControl1.Controls.Add(this.Search);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 1065);
            this.tabControl1.TabIndex = 0;
            // 
            // MovieList
            // 
            this.MovieList.Controls.Add(this.panel1);
            this.MovieList.Controls.Add(this.lbList);
            this.MovieList.Location = new System.Drawing.Point(4, 34);
            this.MovieList.Name = "MovieList";
            this.MovieList.Padding = new System.Windows.Forms.Padding(3);
            this.MovieList.Size = new System.Drawing.Size(542, 1027);
            this.MovieList.TabIndex = 0;
            this.MovieList.Text = "Movie List";
            this.MovieList.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.btnDeleteList);
            this.panel1.Controls.Add(this.btnRenameList);
            this.panel1.Controls.Add(this.btnAddList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 903);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 121);
            this.panel1.TabIndex = 4;
            // 
            // btnDeleteList
            // 
            this.btnDeleteList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteList.Location = new System.Drawing.Point(346, 16);
            this.btnDeleteList.Name = "btnDeleteList";
            this.btnDeleteList.Size = new System.Drawing.Size(119, 100);
            this.btnDeleteList.TabIndex = 4;
            this.btnDeleteList.Text = "delete selected list";
            this.btnDeleteList.UseVisualStyleBackColor = true;
            this.btnDeleteList.Click += new System.EventHandler(this.btnDeleteList_Click);
            // 
            // btnRenameList
            // 
            this.btnRenameList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRenameList.Location = new System.Drawing.Point(206, 16);
            this.btnRenameList.Name = "btnRenameList";
            this.btnRenameList.Size = new System.Drawing.Size(119, 100);
            this.btnRenameList.TabIndex = 3;
            this.btnRenameList.Text = "Rename selected list";
            this.btnRenameList.UseVisualStyleBackColor = true;
            this.btnRenameList.Click += new System.EventHandler(this.btnRenameList_Click);
            // 
            // btnAddList
            // 
            this.btnAddList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddList.Location = new System.Drawing.Point(74, 16);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(112, 100);
            this.btnAddList.TabIndex = 2;
            this.btnAddList.Text = "Add a list";
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // lbList
            // 
            this.lbList.AllowDrop = true;
            this.lbList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbList.ContextMenuStrip = this.cmsMovieList;
            this.lbList.Font = new System.Drawing.Font("Arial", 19.97906F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbList.FormattingEnabled = true;
            this.lbList.ItemHeight = 60;
            this.lbList.Location = new System.Drawing.Point(24, 22);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(493, 844);
            this.lbList.TabIndex = 0;
            this.lbList.SelectedIndexChanged += new System.EventHandler(this.lbList_SelectedIndexChanged);
            this.lbList.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbList_DragDrop);
            this.lbList.DragOver += new System.Windows.Forms.DragEventHandler(this.lbList_DragOver);
            // 
            // cmsMovieList
            // 
            this.cmsMovieList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAListToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem2});
            this.cmsMovieList.Name = "cmsMovieList";
            this.cmsMovieList.Size = new System.Drawing.Size(325, 124);
            // 
            // addAListToolStripMenuItem
            // 
            this.addAListToolStripMenuItem.Name = "addAListToolStripMenuItem";
            this.addAListToolStripMenuItem.Size = new System.Drawing.Size(324, 40);
            this.addAListToolStripMenuItem.Text = "Add a List";
            this.addAListToolStripMenuItem.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(324, 40);
            this.renameToolStripMenuItem.Text = "Rename Selected List";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.btnRenameList_Click);
            // 
            // deleteToolStripMenuItem2
            // 
            this.deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            this.deleteToolStripMenuItem2.Size = new System.Drawing.Size(324, 40);
            this.deleteToolStripMenuItem2.Text = "Delete Selected List";
            this.deleteToolStripMenuItem2.Click += new System.EventHandler(this.btnDeleteList_Click);
            // 
            // Search
            // 
            this.Search.Controls.Add(this.groupBox3);
            this.Search.Controls.Add(this.groupBox2);
            this.Search.Controls.Add(this.groupBox1);
            this.Search.Controls.Add(this.btnSearch);
            this.Search.Controls.Add(this.txtDirector);
            this.Search.Controls.Add(this.label6);
            this.Search.Controls.Add(this.txtCast);
            this.Search.Controls.Add(this.txtTitle);
            this.Search.Controls.Add(this.label2);
            this.Search.Controls.Add(this.label1);
            this.Search.Location = new System.Drawing.Point(4, 34);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(3);
            this.Search.Size = new System.Drawing.Size(542, 1027);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMax);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(47, 818);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(408, 118);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Running Time";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(171, 53);
            this.txtMax.MaxLength = 4;
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(164, 31);
            this.txtMax.TabIndex = 27;
            this.txtMax.TextChanged += new System.EventHandler(this.btnSearch_Click);
            this.txtMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validating_numKey);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "Maximum";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbNC17);
            this.groupBox2.Controls.Add(this.cbR);
            this.groupBox2.Controls.Add(this.cbPG13);
            this.groupBox2.Controls.Add(this.cbPG);
            this.groupBox2.Controls.Add(this.cbG);
            this.groupBox2.Location = new System.Drawing.Point(47, 515);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 288);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rating";
            // 
            // cbNC17
            // 
            this.cbNC17.AutoSize = true;
            this.cbNC17.Location = new System.Drawing.Point(21, 232);
            this.cbNC17.Name = "cbNC17";
            this.cbNC17.Size = new System.Drawing.Size(101, 30);
            this.cbNC17.TabIndex = 26;
            this.cbNC17.Text = "NC-17";
            this.cbNC17.UseVisualStyleBackColor = true;
            this.cbNC17.CheckedChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbR
            // 
            this.cbR.AutoSize = true;
            this.cbR.Location = new System.Drawing.Point(21, 187);
            this.cbR.Name = "cbR";
            this.cbR.Size = new System.Drawing.Size(54, 30);
            this.cbR.TabIndex = 25;
            this.cbR.Text = "R";
            this.cbR.UseVisualStyleBackColor = true;
            this.cbR.CheckedChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbPG13
            // 
            this.cbPG13.AutoSize = true;
            this.cbPG13.Location = new System.Drawing.Point(21, 140);
            this.cbPG13.Name = "cbPG13";
            this.cbPG13.Size = new System.Drawing.Size(101, 30);
            this.cbPG13.TabIndex = 24;
            this.cbPG13.Text = "PG-13";
            this.cbPG13.UseVisualStyleBackColor = true;
            this.cbPG13.CheckedChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbPG
            // 
            this.cbPG.AutoSize = true;
            this.cbPG.Location = new System.Drawing.Point(21, 93);
            this.cbPG.Name = "cbPG";
            this.cbPG.Size = new System.Drawing.Size(70, 30);
            this.cbPG.TabIndex = 23;
            this.cbPG.Text = "PG";
            this.cbPG.UseVisualStyleBackColor = true;
            this.cbPG.CheckedChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbG
            // 
            this.cbG.AutoSize = true;
            this.cbG.Location = new System.Drawing.Point(21, 46);
            this.cbG.Name = "cbG";
            this.cbG.Size = new System.Drawing.Size(55, 30);
            this.cbG.TabIndex = 22;
            this.cbG.Text = "G";
            this.cbG.UseVisualStyleBackColor = true;
            this.cbG.CheckedChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAnimation5);
            this.groupBox1.Controls.Add(this.cbHorror4);
            this.groupBox1.Controls.Add(this.cbSciFi0);
            this.groupBox1.Controls.Add(this.cbThriller3);
            this.groupBox1.Controls.Add(this.cbDrama1);
            this.groupBox1.Controls.Add(this.cbAction2);
            this.groupBox1.Location = new System.Drawing.Point(47, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 169);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genre";
            // 
            // cbAnimation5
            // 
            this.cbAnimation5.AutoSize = true;
            this.cbAnimation5.Location = new System.Drawing.Point(259, 107);
            this.cbAnimation5.Name = "cbAnimation5";
            this.cbAnimation5.Size = new System.Drawing.Size(136, 30);
            this.cbAnimation5.TabIndex = 21;
            this.cbAnimation5.Text = "Animation";
            this.cbAnimation5.UseVisualStyleBackColor = true;
            this.cbAnimation5.CheckedChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbHorror4
            // 
            this.cbHorror4.AutoSize = true;
            this.cbHorror4.Location = new System.Drawing.Point(130, 108);
            this.cbHorror4.Name = "cbHorror4";
            this.cbHorror4.Size = new System.Drawing.Size(99, 30);
            this.cbHorror4.TabIndex = 20;
            this.cbHorror4.Text = "Horror";
            this.cbHorror4.UseVisualStyleBackColor = true;
            this.cbHorror4.CheckedChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbSciFi0
            // 
            this.cbSciFi0.AutoSize = true;
            this.cbSciFi0.Location = new System.Drawing.Point(21, 50);
            this.cbSciFi0.Name = "cbSciFi0";
            this.cbSciFi0.Size = new System.Drawing.Size(87, 30);
            this.cbSciFi0.TabIndex = 16;
            this.cbSciFi0.Text = "SciFi";
            this.cbSciFi0.UseVisualStyleBackColor = true;
            this.cbSciFi0.CheckedChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbThriller3
            // 
            this.cbThriller3.AutoSize = true;
            this.cbThriller3.Location = new System.Drawing.Point(21, 108);
            this.cbThriller3.Name = "cbThriller3";
            this.cbThriller3.Size = new System.Drawing.Size(103, 30);
            this.cbThriller3.TabIndex = 19;
            this.cbThriller3.Text = "Thriller";
            this.cbThriller3.UseVisualStyleBackColor = true;
            this.cbThriller3.CheckedChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbDrama1
            // 
            this.cbDrama1.AutoSize = true;
            this.cbDrama1.Location = new System.Drawing.Point(126, 50);
            this.cbDrama1.Name = "cbDrama1";
            this.cbDrama1.Size = new System.Drawing.Size(104, 30);
            this.cbDrama1.TabIndex = 17;
            this.cbDrama1.Text = "Drama";
            this.cbDrama1.UseVisualStyleBackColor = true;
            this.cbDrama1.CheckedChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbAction2
            // 
            this.cbAction2.AutoSize = true;
            this.cbAction2.Location = new System.Drawing.Point(259, 50);
            this.cbAction2.Name = "cbAction2";
            this.cbAction2.Size = new System.Drawing.Size(99, 30);
            this.cbAction2.TabIndex = 18;
            this.cbAction2.Text = "Action";
            this.cbAction2.UseVisualStyleBackColor = true;
            this.cbAction2.CheckedChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSearch.Location = new System.Drawing.Point(47, 952);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(408, 50);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(47, 174);
            this.txtDirector.MaxLength = 99;
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(408, 31);
            this.txtDirector.TabIndex = 14;
            this.txtDirector.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Director";
            // 
            // txtCast
            // 
            this.txtCast.Location = new System.Drawing.Point(47, 262);
            this.txtCast.MaxLength = 99;
            this.txtCast.Name = "txtCast";
            this.txtCast.Size = new System.Drawing.Size(408, 31);
            this.txtCast.TabIndex = 15;
            this.txtCast.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(47, 72);
            this.txtTitle.MaxLength = 99;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(408, 31);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cast";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Title";
            // 
            // pMovieView
            // 
            this.pMovieView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pMovieView.BackColor = System.Drawing.Color.White;
            this.pMovieView.Controls.Add(this.panel4);
            this.pMovieView.Controls.Add(this.panel3);
            this.pMovieView.Controls.Add(this.panel2);
            this.pMovieView.Location = new System.Drawing.Point(-2, 3);
            this.pMovieView.Name = "pMovieView";
            this.pMovieView.Size = new System.Drawing.Size(1095, 1059);
            this.pMovieView.TabIndex = 1;
            this.pMovieView.Visible = false;
            this.pMovieView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvSimilarMovies_MouseDoubleClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ptxtLength);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.ptxtRating);
            this.panel4.Controls.Add(this.ptxtYear);
            this.panel4.Controls.Add(this.ptxtGenre);
            this.panel4.Controls.Add(this.ptxtCast);
            this.panel4.Controls.Add(this.ptxtDirector);
            this.panel4.Controls.Add(this.lbRating);
            this.panel4.Controls.Add(this.lbYear);
            this.panel4.Controls.Add(this.lbGenre);
            this.panel4.Controls.Add(this.lbCast);
            this.panel4.Controls.Add(this.lbDirector);
            this.panel4.Controls.Add(this.pTrailer);
            this.panel4.Controls.Add(this.btnPanelClose);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(401, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(694, 630);
            this.panel4.TabIndex = 23;
            // 
            // ptxtLength
            // 
            this.ptxtLength.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptxtLength.BackColor = System.Drawing.SystemColors.Window;
            this.ptxtLength.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ptxtLength.Location = new System.Drawing.Point(205, 498);
            this.ptxtLength.Name = "ptxtLength";
            this.ptxtLength.ReadOnly = true;
            this.ptxtLength.Size = new System.Drawing.Size(100, 24);
            this.ptxtLength.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 26);
            this.label3.TabIndex = 31;
            this.label3.Text = "Running Time";
            // 
            // ptxtRating
            // 
            this.ptxtRating.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptxtRating.BackColor = System.Drawing.SystemColors.Window;
            this.ptxtRating.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ptxtRating.Location = new System.Drawing.Point(153, 444);
            this.ptxtRating.Name = "ptxtRating";
            this.ptxtRating.ReadOnly = true;
            this.ptxtRating.Size = new System.Drawing.Size(152, 24);
            this.ptxtRating.TabIndex = 30;
            // 
            // ptxtYear
            // 
            this.ptxtYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptxtYear.BackColor = System.Drawing.SystemColors.Window;
            this.ptxtYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ptxtYear.Location = new System.Drawing.Point(153, 391);
            this.ptxtYear.Name = "ptxtYear";
            this.ptxtYear.ReadOnly = true;
            this.ptxtYear.Size = new System.Drawing.Size(152, 24);
            this.ptxtYear.TabIndex = 29;
            // 
            // ptxtGenre
            // 
            this.ptxtGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptxtGenre.BackColor = System.Drawing.SystemColors.Window;
            this.ptxtGenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ptxtGenre.Location = new System.Drawing.Point(153, 337);
            this.ptxtGenre.Name = "ptxtGenre";
            this.ptxtGenre.ReadOnly = true;
            this.ptxtGenre.Size = new System.Drawing.Size(520, 24);
            this.ptxtGenre.TabIndex = 28;
            // 
            // ptxtCast
            // 
            this.ptxtCast.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptxtCast.BackColor = System.Drawing.SystemColors.Window;
            this.ptxtCast.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ptxtCast.Location = new System.Drawing.Point(153, 238);
            this.ptxtCast.Multiline = true;
            this.ptxtCast.Name = "ptxtCast";
            this.ptxtCast.ReadOnly = true;
            this.ptxtCast.Size = new System.Drawing.Size(520, 93);
            this.ptxtCast.TabIndex = 27;
            // 
            // ptxtDirector
            // 
            this.ptxtDirector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptxtDirector.BackColor = System.Drawing.SystemColors.Window;
            this.ptxtDirector.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ptxtDirector.Location = new System.Drawing.Point(153, 174);
            this.ptxtDirector.Name = "ptxtDirector";
            this.ptxtDirector.ReadOnly = true;
            this.ptxtDirector.Size = new System.Drawing.Size(520, 24);
            this.ptxtDirector.TabIndex = 26;
            // 
            // lbRating
            // 
            this.lbRating.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRating.AutoSize = true;
            this.lbRating.Location = new System.Drawing.Point(37, 442);
            this.lbRating.Name = "lbRating";
            this.lbRating.Size = new System.Drawing.Size(75, 26);
            this.lbRating.TabIndex = 25;
            this.lbRating.Text = "Rating";
            // 
            // lbYear
            // 
            this.lbYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(50, 389);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(59, 26);
            this.lbYear.TabIndex = 24;
            this.lbYear.Text = "Year";
            // 
            // lbGenre
            // 
            this.lbGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGenre.AutoSize = true;
            this.lbGenre.Location = new System.Drawing.Point(37, 335);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(72, 26);
            this.lbGenre.TabIndex = 23;
            this.lbGenre.Text = "Genre";
            // 
            // lbCast
            // 
            this.lbCast.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCast.AutoSize = true;
            this.lbCast.Location = new System.Drawing.Point(52, 238);
            this.lbCast.Name = "lbCast";
            this.lbCast.Size = new System.Drawing.Size(57, 26);
            this.lbCast.TabIndex = 22;
            this.lbCast.Text = "Cast";
            // 
            // lbDirector
            // 
            this.lbDirector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDirector.AutoSize = true;
            this.lbDirector.Location = new System.Drawing.Point(21, 172);
            this.lbDirector.Name = "lbDirector";
            this.lbDirector.Size = new System.Drawing.Size(88, 26);
            this.lbDirector.TabIndex = 21;
            this.lbDirector.Text = "Director";
            // 
            // pTrailer
            // 
            this.pTrailer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pTrailer.Location = new System.Drawing.Point(325, 391);
            this.pTrailer.Name = "pTrailer";
            this.pTrailer.Size = new System.Drawing.Size(348, 180);
            this.pTrailer.TabIndex = 20;
            // 
            // btnPanelClose
            // 
            this.btnPanelClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPanelClose.Location = new System.Drawing.Point(502, 60);
            this.btnPanelClose.Name = "btnPanelClose";
            this.btnPanelClose.Size = new System.Drawing.Size(171, 51);
            this.btnPanelClose.TabIndex = 19;
            this.btnPanelClose.Text = "Close";
            this.btnPanelClose.UseVisualStyleBackColor = true;
            this.btnPanelClose.Click += new System.EventHandler(this.btnPanelClose_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ptxtTitle);
            this.panel3.Controls.Add(this.pbPoster);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(401, 630);
            this.panel3.TabIndex = 22;
            // 
            // ptxtTitle
            // 
            this.ptxtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptxtTitle.BackColor = System.Drawing.SystemColors.Window;
            this.ptxtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ptxtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.17801F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptxtTitle.Location = new System.Drawing.Point(24, 523);
            this.ptxtTitle.Multiline = true;
            this.ptxtTitle.Name = "ptxtTitle";
            this.ptxtTitle.ReadOnly = true;
            this.ptxtTitle.Size = new System.Drawing.Size(349, 104);
            this.ptxtTitle.TabIndex = 22;
            this.ptxtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbPoster
            // 
            this.pbPoster.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPoster.Location = new System.Drawing.Point(24, 45);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(349, 478);
            this.pbPoster.TabIndex = 21;
            this.pbPoster.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lvSimilarMovies);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 630);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1095, 429);
            this.panel2.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(494, 26);
            this.label4.TabIndex = 21;
            this.label4.Text = "Similar Movies(from same genre, director, cast .. )";
            // 
            // lvSimilarMovies
            // 
            this.lvSimilarMovies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSimilarMovies.Location = new System.Drawing.Point(40, 56);
            this.lvSimilarMovies.Name = "lvSimilarMovies";
            this.lvSimilarMovies.Size = new System.Drawing.Size(1019, 341);
            this.lvSimilarMovies.TabIndex = 20;
            this.lvSimilarMovies.UseCompatibleStateImageBehavior = false;
            this.lvSimilarMovies.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvSimilarMovies_MouseDoubleClick);
            // 
            // lvMovie
            // 
            this.lvMovie.ContextMenuStrip = this.cmsMovieAdd;
            this.lvMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMovie.Location = new System.Drawing.Point(0, 31);
            this.lvMovie.MultiSelect = false;
            this.lvMovie.Name = "lvMovie";
            this.lvMovie.Size = new System.Drawing.Size(1096, 1034);
            this.lvMovie.TabIndex = 3;
            this.lvMovie.UseCompatibleStateImageBehavior = false;
            this.lvMovie.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvMovie_MouseDoubleClick);
            this.lvMovie.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvMovie_MouseDown);
            // 
            // cmsMovieAdd
            // 
            this.cmsMovieAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToAListToolStripMenuItem,
            this.removeFromThisListToolStripMenuItem});
            this.cmsMovieAdd.Name = "cmsMovieAddDelete";
            this.cmsMovieAdd.Size = new System.Drawing.Size(336, 84);
            this.cmsMovieAdd.Opened += new System.EventHandler(this.dynamicAddItems);
            // 
            // addToAListToolStripMenuItem
            // 
            this.addToAListToolStripMenuItem.Name = "addToAListToolStripMenuItem";
            this.addToAListToolStripMenuItem.Size = new System.Drawing.Size(335, 40);
            this.addToAListToolStripMenuItem.Text = "Add to a List";
            // 
            // removeFromThisListToolStripMenuItem
            // 
            this.removeFromThisListToolStripMenuItem.Name = "removeFromThisListToolStripMenuItem";
            this.removeFromThisListToolStripMenuItem.Size = new System.Drawing.Size(335, 40);
            this.removeFromThisListToolStripMenuItem.Text = "Remove From this List";
            this.removeFromThisListToolStripMenuItem.Click += new System.EventHandler(this.removeFromThisListToolStripMenuItem_Click);
            // 
            // txtCount
            // 
            this.txtCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCount.Location = new System.Drawing.Point(0, 0);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(1096, 31);
            this.txtCount.TabIndex = 2;
            this.txtCount.TextChanged += new System.EventHandler(this.txtCount_TextChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1650, 1108);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieOrganizer";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.MovieList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.cmsMovieList.ResumeLayout(false);
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pMovieView.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.cmsMovieAdd.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MovieList;
        private System.Windows.Forms.TabPage Search;
        private System.Windows.Forms.TextBox txtCast;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movieListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.Panel pMovieView;
        private System.Windows.Forms.CheckBox cbThriller3;
        private System.Windows.Forms.CheckBox cbAction2;
        private System.Windows.Forms.CheckBox cbDrama1;
        private System.Windows.Forms.CheckBox cbSciFi0;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbPG13;
        private System.Windows.Forms.CheckBox cbPG;
        private System.Windows.Forms.CheckBox cbG;
        private System.Windows.Forms.CheckBox cbNC17;
        private System.Windows.Forms.CheckBox cbR;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteList;
        private System.Windows.Forms.Button btnRenameList;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.ContextMenuStrip cmsMovieList;
        private System.Windows.Forms.ToolStripMenuItem addAListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip cmsMovieAdd;
        private System.Windows.Forms.ToolStripMenuItem addToAListToolStripMenuItem;
        private System.Windows.Forms.ListBox lbList;
        private System.Windows.Forms.ToolStripMenuItem removeFromThisListToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbAnimation5;
        private System.Windows.Forms.CheckBox cbHorror4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvMovie;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox ptxtLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ptxtRating;
        private System.Windows.Forms.TextBox ptxtYear;
        private System.Windows.Forms.TextBox ptxtGenre;
        private System.Windows.Forms.TextBox ptxtCast;
        private System.Windows.Forms.TextBox ptxtDirector;
        private System.Windows.Forms.Label lbRating;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Label lbCast;
        private System.Windows.Forms.Label lbDirector;
        private System.Windows.Forms.Panel pTrailer;
        private System.Windows.Forms.Button btnPanelClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox ptxtTitle;
        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvSimilarMovies;
    }
}

