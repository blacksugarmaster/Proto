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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btnDeleteList = new System.Windows.Forms.Button();
            this.btnEditList = new System.Windows.Forms.Button();
            this.btnAddList = new System.Windows.Forms.Button();
            this.lbList = new System.Windows.Forms.ListBox();
            this.Search = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listGenre = new System.Windows.Forms.ListBox();
            this.txtCast = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pOverlay = new System.Windows.Forms.Panel();
            this.pMovieView = new System.Windows.Forms.Panel();
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.MovieList.SuspendLayout();
            this.Search.SuspendLayout();
            this.pMovieView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
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
            this.exitToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(153, 39);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(158, 40);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 40);
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
            this.listAddToolStripMenuItem.Size = new System.Drawing.Size(243, 40);
            this.listAddToolStripMenuItem.Text = "Add";
            this.listAddToolStripMenuItem.Click += new System.EventHandler(this.listAddToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(243, 40);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(243, 40);
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
            this.splitContainer1.Panel2.Controls.Add(this.pOverlay);
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
            this.tabControl1.Size = new System.Drawing.Size(525, 1040);
            this.tabControl1.TabIndex = 0;
            // 
            // MovieList
            // 
            this.MovieList.Controls.Add(this.btnDeleteList);
            this.MovieList.Controls.Add(this.btnEditList);
            this.MovieList.Controls.Add(this.btnAddList);
            this.MovieList.Controls.Add(this.lbList);
            this.MovieList.Location = new System.Drawing.Point(4, 34);
            this.MovieList.Name = "MovieList";
            this.MovieList.Padding = new System.Windows.Forms.Padding(3);
            this.MovieList.Size = new System.Drawing.Size(517, 1002);
            this.MovieList.TabIndex = 0;
            this.MovieList.Text = "Movie List";
            this.MovieList.UseVisualStyleBackColor = true;
            // 
            // btnDeleteList
            // 
            this.btnDeleteList.Location = new System.Drawing.Point(340, 861);
            this.btnDeleteList.Name = "btnDeleteList";
            this.btnDeleteList.Size = new System.Drawing.Size(119, 120);
            this.btnDeleteList.TabIndex = 3;
            this.btnDeleteList.Text = "delete";
            this.btnDeleteList.UseVisualStyleBackColor = true;
            // 
            // btnEditList
            // 
            this.btnEditList.Location = new System.Drawing.Point(195, 861);
            this.btnEditList.Name = "btnEditList";
            this.btnEditList.Size = new System.Drawing.Size(119, 120);
            this.btnEditList.TabIndex = 2;
            this.btnEditList.Text = "edit";
            this.btnEditList.UseVisualStyleBackColor = true;
            // 
            // btnAddList
            // 
            this.btnAddList.Location = new System.Drawing.Point(50, 861);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(119, 120);
            this.btnAddList.TabIndex = 1;
            this.btnAddList.Text = "add";
            this.btnAddList.UseVisualStyleBackColor = true;
            // 
            // lbList
            // 
            this.lbList.FormattingEnabled = true;
            this.lbList.ItemHeight = 25;
            this.lbList.Location = new System.Drawing.Point(19, 16);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(475, 829);
            this.lbList.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.Controls.Add(this.btnSearch);
            this.Search.Controls.Add(this.txtDirector);
            this.Search.Controls.Add(this.label6);
            this.Search.Controls.Add(this.listGenre);
            this.Search.Controls.Add(this.txtCast);
            this.Search.Controls.Add(this.txtTitle);
            this.Search.Controls.Add(this.label5);
            this.Search.Controls.Add(this.label4);
            this.Search.Controls.Add(this.label3);
            this.Search.Controls.Add(this.label2);
            this.Search.Controls.Add(this.label1);
            this.Search.Location = new System.Drawing.Point(4, 34);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(3);
            this.Search.Size = new System.Drawing.Size(517, 1002);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSearch.Location = new System.Drawing.Point(251, 920);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(173, 50);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(47, 174);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(287, 31);
            this.txtDirector.TabIndex = 17;
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
            // listGenre
            // 
            this.listGenre.FormattingEnabled = true;
            this.listGenre.ItemHeight = 25;
            this.listGenre.Location = new System.Drawing.Point(47, 378);
            this.listGenre.Name = "listGenre";
            this.listGenre.Size = new System.Drawing.Size(287, 254);
            this.listGenre.TabIndex = 15;
            // 
            // txtCast
            // 
            this.txtCast.Location = new System.Drawing.Point(47, 262);
            this.txtCast.Name = "txtCast";
            this.txtCast.Size = new System.Drawing.Size(287, 31);
            this.txtCast.TabIndex = 14;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(47, 72);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(287, 31);
            this.txtTitle.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 806);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Age Range";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 672);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Genre";
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
            // pOverlay
            // 
            this.pOverlay.BackColor = System.Drawing.Color.Transparent;
            this.pOverlay.Location = new System.Drawing.Point(6, 6);
            this.pOverlay.Name = "pOverlay";
            this.pOverlay.Size = new System.Drawing.Size(1093, 344);
            this.pOverlay.TabIndex = 2;
            this.pOverlay.Visible = false;
            // 
            // pMovieView
            // 
            this.pMovieView.BackColor = System.Drawing.Color.White;
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
            this.pMovieView.Location = new System.Drawing.Point(3, 340);
            this.pMovieView.Name = "pMovieView";
            this.pMovieView.Size = new System.Drawing.Size(1090, 722);
            this.pMovieView.TabIndex = 1;
            this.pMovieView.Visible = false;
            // 
            // pbPoster
            // 
            this.pbPoster.Location = new System.Drawing.Point(53, 45);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(349, 478);
            this.pbPoster.TabIndex = 14;
            this.pbPoster.TabStop = false;
            // 
            // ptxtRating
            // 
            this.ptxtRating.Location = new System.Drawing.Point(539, 374);
            this.ptxtRating.Name = "ptxtRating";
            this.ptxtRating.Size = new System.Drawing.Size(100, 31);
            this.ptxtRating.TabIndex = 13;
            // 
            // ptxtYear
            // 
            this.ptxtYear.Location = new System.Drawing.Point(539, 335);
            this.ptxtYear.Name = "ptxtYear";
            this.ptxtYear.Size = new System.Drawing.Size(100, 31);
            this.ptxtYear.TabIndex = 12;
            // 
            // ptxtGenre
            // 
            this.ptxtGenre.Location = new System.Drawing.Point(539, 258);
            this.ptxtGenre.Name = "ptxtGenre";
            this.ptxtGenre.Size = new System.Drawing.Size(100, 31);
            this.ptxtGenre.TabIndex = 11;
            // 
            // ptxtCast
            // 
            this.ptxtCast.Location = new System.Drawing.Point(539, 196);
            this.ptxtCast.Name = "ptxtCast";
            this.ptxtCast.Size = new System.Drawing.Size(100, 31);
            this.ptxtCast.TabIndex = 10;
            // 
            // ptxtDirector
            // 
            this.ptxtDirector.Location = new System.Drawing.Point(539, 126);
            this.ptxtDirector.Name = "ptxtDirector";
            this.ptxtDirector.Size = new System.Drawing.Size(100, 31);
            this.ptxtDirector.TabIndex = 9;
            // 
            // lbRating
            // 
            this.lbRating.AutoSize = true;
            this.lbRating.Location = new System.Drawing.Point(430, 377);
            this.lbRating.Name = "lbRating";
            this.lbRating.Size = new System.Drawing.Size(75, 26);
            this.lbRating.TabIndex = 8;
            this.lbRating.Text = "Rating";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(446, 338);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(59, 26);
            this.lbYear.TabIndex = 7;
            this.lbYear.Text = "Year";
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Location = new System.Drawing.Point(433, 261);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(72, 26);
            this.lbGenre.TabIndex = 6;
            this.lbGenre.Text = "Genre";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(188, 526);
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
            this.pTrailer.Location = new System.Drawing.Point(711, 494);
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
            this.lvMovie.Location = new System.Drawing.Point(3, 0);
            this.lvMovie.Name = "lvMovie";
            this.lvMovie.Size = new System.Drawing.Size(1090, 1062);
            this.lvMovie.TabIndex = 0;
            this.lvMovie.UseCompatibleStateImageBehavior = false;
            this.lvMovie.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvMovie_MouseDoubleClick);
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
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.pMovieView.ResumeLayout(false);
            this.pMovieView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
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
        private System.Windows.Forms.ListBox listGenre;
        private System.Windows.Forms.TextBox txtCast;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.Button btnDeleteList;
        private System.Windows.Forms.Button btnEditList;
        private System.Windows.Forms.Button btnAddList;
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
        private System.Windows.Forms.Panel pOverlay;
        private System.Windows.Forms.Button btnRefresh;
    }
}

