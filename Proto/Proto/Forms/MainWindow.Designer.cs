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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbNC17 = new System.Windows.Forms.CheckBox();
            this.cbR = new System.Windows.Forms.CheckBox();
            this.cbPG13 = new System.Windows.Forms.CheckBox();
            this.cbPG = new System.Windows.Forms.CheckBox();
            this.cbG = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.lbSame = new System.Windows.Forms.Label();
            this.lvSameGenreMovies = new System.Windows.Forms.ListView();
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.ptxtRating = new System.Windows.Forms.TextBox();
            this.ptxtYear = new System.Windows.Forms.TextBox();
            this.ptxtGenre = new System.Windows.Forms.TextBox();
            this.ptxtCast = new System.Windows.Forms.TextBox();
            this.ptxtDirector = new System.Windows.Forms.TextBox();
            this.lbRating = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbCast = new System.Windows.Forms.Label();
            this.lbDirector = new System.Windows.Forms.Label();
            this.pTrailer = new System.Windows.Forms.Panel();
            this.btnPanelClose = new System.Windows.Forms.Button();
            this.lvMovie = new System.Windows.Forms.ListView();
            this.cmsMovieAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToAListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmsMovieDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pMovieView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.cmsMovieAdd.SuspendLayout();
            this.cmsMovieDelete.SuspendLayout();
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
            this.listAddToolStripMenuItem.Size = new System.Drawing.Size(161, 40);
            this.listAddToolStripMenuItem.Text = "Add";
            this.listAddToolStripMenuItem.Click += new System.EventHandler(this.listAddToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(161, 40);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(161, 40);
            this.deleteToolStripMenuItem1.Text = "Delete";
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
            this.splitContainer1.Size = new System.Drawing.Size(1650, 1065);
            this.splitContainer1.SplitterDistance = 550;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MovieList);
            this.tabControl1.Controls.Add(this.Search);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(535, 1040);
            this.tabControl1.TabIndex = 0;
            // 
            // MovieList
            // 
            this.MovieList.Controls.Add(this.panel1);
            this.MovieList.Controls.Add(this.lbList);
            this.MovieList.Location = new System.Drawing.Point(4, 34);
            this.MovieList.Name = "MovieList";
            this.MovieList.Padding = new System.Windows.Forms.Padding(3);
            this.MovieList.Size = new System.Drawing.Size(527, 1002);
            this.MovieList.TabIndex = 0;
            this.MovieList.Text = "Movie List";
            this.MovieList.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteList);
            this.panel1.Controls.Add(this.btnRenameList);
            this.panel1.Controls.Add(this.btnAddList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 847);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 152);
            this.panel1.TabIndex = 4;
            // 
            // btnDeleteList
            // 
            this.btnDeleteList.Location = new System.Drawing.Point(352, 16);
            this.btnDeleteList.Name = "btnDeleteList";
            this.btnDeleteList.Size = new System.Drawing.Size(119, 120);
            this.btnDeleteList.TabIndex = 4;
            this.btnDeleteList.Text = "delete";
            this.btnDeleteList.UseVisualStyleBackColor = true;
            this.btnDeleteList.Click += new System.EventHandler(this.btnDeleteList_Click);
            // 
            // btnRenameList
            // 
            this.btnRenameList.Location = new System.Drawing.Point(204, 16);
            this.btnRenameList.Name = "btnRenameList";
            this.btnRenameList.Size = new System.Drawing.Size(119, 120);
            this.btnRenameList.TabIndex = 3;
            this.btnRenameList.Text = "Rename";
            this.btnRenameList.UseVisualStyleBackColor = true;
            this.btnRenameList.Click += new System.EventHandler(this.btnRenameList_Click);
            // 
            // btnAddList
            // 
            this.btnAddList.Location = new System.Drawing.Point(59, 16);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(119, 120);
            this.btnAddList.TabIndex = 2;
            this.btnAddList.Text = "add";
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // lbList
            // 
            this.lbList.ContextMenuStrip = this.cmsMovieList;
            this.lbList.Font = new System.Drawing.Font("Arial", 19.97906F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbList.FormattingEnabled = true;
            this.lbList.ItemHeight = 60;
            this.lbList.Location = new System.Drawing.Point(19, 16);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(493, 784);
            this.lbList.TabIndex = 0;
            this.lbList.SelectedIndexChanged += new System.EventHandler(this.lbList_SelectedIndexChanged);
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
            this.Search.Size = new System.Drawing.Size(527, 1002);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbNC17);
            this.groupBox2.Controls.Add(this.cbR);
            this.groupBox2.Controls.Add(this.cbPG13);
            this.groupBox2.Controls.Add(this.cbPG);
            this.groupBox2.Controls.Add(this.cbG);
            this.groupBox2.Location = new System.Drawing.Point(47, 604);
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
            this.cbNC17.TabIndex = 4;
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
            this.cbR.TabIndex = 3;
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
            this.cbPG13.TabIndex = 2;
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
            this.cbPG.TabIndex = 1;
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
            this.cbG.TabIndex = 0;
            this.cbG.Text = "G";
            this.cbG.UseVisualStyleBackColor = true;
            this.cbG.CheckedChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSciFi0);
            this.groupBox1.Controls.Add(this.cbThriller3);
            this.groupBox1.Controls.Add(this.cbDrama1);
            this.groupBox1.Controls.Add(this.cbAction2);
            this.groupBox1.Location = new System.Drawing.Point(47, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 244);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genre";
            // 
            // cbSciFi0
            // 
            this.cbSciFi0.AutoSize = true;
            this.cbSciFi0.Location = new System.Drawing.Point(21, 50);
            this.cbSciFi0.Name = "cbSciFi0";
            this.cbSciFi0.Size = new System.Drawing.Size(87, 30);
            this.cbSciFi0.TabIndex = 19;
            this.cbSciFi0.Text = "SciFi";
            this.cbSciFi0.UseVisualStyleBackColor = true;
            this.cbSciFi0.CheckedChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbThriller3
            // 
            this.cbThriller3.AutoSize = true;
            this.cbThriller3.Location = new System.Drawing.Point(21, 198);
            this.cbThriller3.Name = "cbThriller3";
            this.cbThriller3.Size = new System.Drawing.Size(103, 30);
            this.cbThriller3.TabIndex = 22;
            this.cbThriller3.Text = "Thriller";
            this.cbThriller3.UseVisualStyleBackColor = true;
            this.cbThriller3.CheckedChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbDrama1
            // 
            this.cbDrama1.AutoSize = true;
            this.cbDrama1.Location = new System.Drawing.Point(21, 98);
            this.cbDrama1.Name = "cbDrama1";
            this.cbDrama1.Size = new System.Drawing.Size(104, 30);
            this.cbDrama1.TabIndex = 20;
            this.cbDrama1.Text = "Drama";
            this.cbDrama1.UseVisualStyleBackColor = true;
            this.cbDrama1.CheckedChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbAction2
            // 
            this.cbAction2.AutoSize = true;
            this.cbAction2.Location = new System.Drawing.Point(21, 147);
            this.cbAction2.Name = "cbAction2";
            this.cbAction2.Size = new System.Drawing.Size(99, 30);
            this.cbAction2.TabIndex = 21;
            this.cbAction2.Text = "Action";
            this.cbAction2.UseVisualStyleBackColor = true;
            this.cbAction2.CheckedChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSearch.Location = new System.Drawing.Point(47, 922);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(408, 50);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(47, 174);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(408, 31);
            this.txtDirector.TabIndex = 17;
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
            this.txtCast.Name = "txtCast";
            this.txtCast.Size = new System.Drawing.Size(408, 31);
            this.txtCast.TabIndex = 14;
            this.txtCast.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(47, 72);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(408, 31);
            this.txtTitle.TabIndex = 13;
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
            this.pMovieView.BackColor = System.Drawing.Color.White;
            this.pMovieView.Controls.Add(this.lbSame);
            this.pMovieView.Controls.Add(this.lvSameGenreMovies);
            this.pMovieView.Controls.Add(this.pbPoster);
            this.pMovieView.Controls.Add(this.ptxtRating);
            this.pMovieView.Controls.Add(this.ptxtYear);
            this.pMovieView.Controls.Add(this.ptxtGenre);
            this.pMovieView.Controls.Add(this.ptxtCast);
            this.pMovieView.Controls.Add(this.ptxtDirector);
            this.pMovieView.Controls.Add(this.lbRating);
            this.pMovieView.Controls.Add(this.lbYear);
            this.pMovieView.Controls.Add(this.lbGenre);
            this.pMovieView.Controls.Add(this.lbTitle);
            this.pMovieView.Controls.Add(this.lbCast);
            this.pMovieView.Controls.Add(this.lbDirector);
            this.pMovieView.Controls.Add(this.pTrailer);
            this.pMovieView.Controls.Add(this.btnPanelClose);
            this.pMovieView.Location = new System.Drawing.Point(3, 105);
            this.pMovieView.Name = "pMovieView";
            this.pMovieView.Size = new System.Drawing.Size(1090, 957);
            this.pMovieView.TabIndex = 1;
            this.pMovieView.Visible = false;
            // 
            // lbSame
            // 
            this.lbSame.AutoSize = true;
            this.lbSame.Location = new System.Drawing.Point(42, 707);
            this.lbSame.Name = "lbSame";
            this.lbSame.Size = new System.Drawing.Size(206, 26);
            this.lbSame.TabIndex = 16;
            this.lbSame.Text = "Same genre Movies";
            // 
            // lvSameGenreMovies
            // 
            this.lvSameGenreMovies.Location = new System.Drawing.Point(40, 736);
            this.lvSameGenreMovies.Name = "lvSameGenreMovies";
            this.lvSameGenreMovies.Size = new System.Drawing.Size(1019, 294);
            this.lvSameGenreMovies.TabIndex = 15;
            this.lvSameGenreMovies.UseCompatibleStateImageBehavior = false;
            // 
            // pbPoster
            // 
            this.pbPoster.Location = new System.Drawing.Point(40, 47);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(349, 478);
            this.pbPoster.TabIndex = 14;
            this.pbPoster.TabStop = false;
            // 
            // ptxtRating
            // 
            this.ptxtRating.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ptxtRating.Location = new System.Drawing.Point(539, 442);
            this.ptxtRating.Name = "ptxtRating";
            this.ptxtRating.Size = new System.Drawing.Size(100, 24);
            this.ptxtRating.TabIndex = 13;
            // 
            // ptxtYear
            // 
            this.ptxtYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ptxtYear.Location = new System.Drawing.Point(539, 391);
            this.ptxtYear.Name = "ptxtYear";
            this.ptxtYear.Size = new System.Drawing.Size(100, 24);
            this.ptxtYear.TabIndex = 12;
            // 
            // ptxtGenre
            // 
            this.ptxtGenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ptxtGenre.Location = new System.Drawing.Point(539, 345);
            this.ptxtGenre.Name = "ptxtGenre";
            this.ptxtGenre.Size = new System.Drawing.Size(520, 24);
            this.ptxtGenre.TabIndex = 11;
            // 
            // ptxtCast
            // 
            this.ptxtCast.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ptxtCast.Location = new System.Drawing.Point(539, 196);
            this.ptxtCast.Multiline = true;
            this.ptxtCast.Name = "ptxtCast";
            this.ptxtCast.Size = new System.Drawing.Size(520, 31);
            this.ptxtCast.TabIndex = 10;
            // 
            // ptxtDirector
            // 
            this.ptxtDirector.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ptxtDirector.Location = new System.Drawing.Point(539, 126);
            this.ptxtDirector.Name = "ptxtDirector";
            this.ptxtDirector.Size = new System.Drawing.Size(520, 24);
            this.ptxtDirector.TabIndex = 9;
            // 
            // lbRating
            // 
            this.lbRating.AutoSize = true;
            this.lbRating.Location = new System.Drawing.Point(430, 445);
            this.lbRating.Name = "lbRating";
            this.lbRating.Size = new System.Drawing.Size(75, 26);
            this.lbRating.TabIndex = 8;
            this.lbRating.Text = "Rating";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(446, 394);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(59, 26);
            this.lbYear.TabIndex = 7;
            this.lbYear.Text = "Year";
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Location = new System.Drawing.Point(433, 348);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(72, 26);
            this.lbGenre.TabIndex = 6;
            this.lbGenre.Text = "Genre";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(178, 528);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(70, 26);
            this.lbTitle.TabIndex = 5;
            this.lbTitle.Text = "label8";
            // 
            // lbCast
            // 
            this.lbCast.AutoSize = true;
            this.lbCast.Location = new System.Drawing.Point(448, 199);
            this.lbCast.Name = "lbCast";
            this.lbCast.Size = new System.Drawing.Size(57, 26);
            this.lbCast.TabIndex = 4;
            this.lbCast.Text = "Cast";
            // 
            // lbDirector
            // 
            this.lbDirector.AutoSize = true;
            this.lbDirector.Location = new System.Drawing.Point(417, 129);
            this.lbDirector.Name = "lbDirector";
            this.lbDirector.Size = new System.Drawing.Size(88, 26);
            this.lbDirector.TabIndex = 3;
            this.lbDirector.Text = "Director";
            // 
            // pTrailer
            // 
            this.pTrailer.Location = new System.Drawing.Point(711, 394);
            this.pTrailer.Name = "pTrailer";
            this.pTrailer.Size = new System.Drawing.Size(348, 194);
            this.pTrailer.TabIndex = 2;
            // 
            // btnPanelClose
            // 
            this.btnPanelClose.Location = new System.Drawing.Point(888, 45);
            this.btnPanelClose.Name = "btnPanelClose";
            this.btnPanelClose.Size = new System.Drawing.Size(171, 51);
            this.btnPanelClose.TabIndex = 1;
            this.btnPanelClose.Text = "Close";
            this.btnPanelClose.UseVisualStyleBackColor = true;
            this.btnPanelClose.Click += new System.EventHandler(this.btnPanelClose_Click);
            // 
            // lvMovie
            // 
            this.lvMovie.ContextMenuStrip = this.cmsMovieAdd;
            this.lvMovie.Location = new System.Drawing.Point(3, 0);
            this.lvMovie.Name = "lvMovie";
            this.lvMovie.Size = new System.Drawing.Size(1090, 1062);
            this.lvMovie.TabIndex = 0;
            this.lvMovie.UseCompatibleStateImageBehavior = false;
            this.lvMovie.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvMovie_MouseDoubleClick);
            // 
            // cmsMovieAdd
            // 
            this.cmsMovieAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToAListToolStripMenuItem});
            this.cmsMovieAdd.Name = "cmsMovieAddDelete";
            this.cmsMovieAdd.Size = new System.Drawing.Size(244, 88);
            this.cmsMovieAdd.Opened += new System.EventHandler(this.dynamicAddItems);
            // 
            // addToAListToolStripMenuItem
            // 
            this.addToAListToolStripMenuItem.Name = "addToAListToolStripMenuItem";
            this.addToAListToolStripMenuItem.Size = new System.Drawing.Size(230, 40);
            this.addToAListToolStripMenuItem.Text = "Add to a List";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1247, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(400, 43);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmsMovieDelete
            // 
            this.cmsMovieDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.cmsMovieDelete.Name = "cmsMovieAddDelete";
            this.cmsMovieDelete.Size = new System.Drawing.Size(313, 44);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(312, 40);
            this.toolStripMenuItem1.Text = "Delete From the List";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1650, 1108);
            this.Controls.Add(this.btnRefresh);
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.MovieList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.cmsMovieList.ResumeLayout(false);
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pMovieView.ResumeLayout(false);
            this.pMovieView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.cmsMovieAdd.ResumeLayout(false);
            this.cmsMovieDelete.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox lbList;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movieListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lvMovie;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.Panel pMovieView;
        private System.Windows.Forms.Button btnPanelClose;
        private System.Windows.Forms.Panel pTrailer;
        private System.Windows.Forms.Label lbRating;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbCast;
        private System.Windows.Forms.Label lbDirector;
        private System.Windows.Forms.TextBox ptxtRating;
        private System.Windows.Forms.TextBox ptxtYear;
        private System.Windows.Forms.TextBox ptxtGenre;
        private System.Windows.Forms.TextBox ptxtCast;
        private System.Windows.Forms.TextBox ptxtDirector;
        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.Button btnRefresh;
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
        private System.Windows.Forms.ListView lvSameGenreMovies;
        private System.Windows.Forms.Label lbSame;
        private System.Windows.Forms.ContextMenuStrip cmsMovieList;
        private System.Windows.Forms.ToolStripMenuItem addAListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip cmsMovieAdd;
        private System.Windows.Forms.ToolStripMenuItem addToAListToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsMovieDelete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

