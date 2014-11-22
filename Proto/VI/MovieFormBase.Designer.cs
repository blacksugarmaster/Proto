namespace Proto.Forms
{
    partial class MovieBase
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbThriller = new System.Windows.Forms.CheckBox();
            this.cbAction = new System.Windows.Forms.CheckBox();
            this.cbSciFi = new System.Windows.Forms.CheckBox();
            this.cbDrama = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNC17 = new System.Windows.Forms.RadioButton();
            this.rbR = new System.Windows.Forms.RadioButton();
            this.rbPG13 = new System.Windows.Forms.RadioButton();
            this.rbPG = new System.Windows.Forms.RadioButton();
            this.rbG = new System.Windows.Forms.RadioButton();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.lbCast = new System.Windows.Forms.ListBox();
            this.txtCast = new System.Windows.Forms.TextBox();
            this.btnAddCast = new System.Windows.Forms.Button();
            this.btnDeleteCast = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtImage = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Director";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cast";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(208, 26);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(248, 31);
            this.txtTitle.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(109, 954);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(192, 69);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(340, 954);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(192, 69);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbThriller);
            this.groupBox1.Controls.Add(this.cbAction);
            this.groupBox1.Controls.Add(this.cbSciFi);
            this.groupBox1.Controls.Add(this.cbDrama);
            this.groupBox1.Location = new System.Drawing.Point(60, 649);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 174);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genre";
            // 
            // cbThriller
            // 
            this.cbThriller.AutoSize = true;
            this.cbThriller.Location = new System.Drawing.Point(148, 30);
            this.cbThriller.Name = "cbThriller";
            this.cbThriller.Size = new System.Drawing.Size(103, 30);
            this.cbThriller.TabIndex = 3;
            this.cbThriller.Text = "Thriller";
            this.cbThriller.UseVisualStyleBackColor = true;
            // 
            // cbAction
            // 
            this.cbAction.AutoSize = true;
            this.cbAction.Location = new System.Drawing.Point(16, 125);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(99, 30);
            this.cbAction.TabIndex = 2;
            this.cbAction.Text = "Action";
            this.cbAction.UseVisualStyleBackColor = true;
            // 
            // cbSciFi
            // 
            this.cbSciFi.AutoSize = true;
            this.cbSciFi.Location = new System.Drawing.Point(16, 79);
            this.cbSciFi.Name = "cbSciFi";
            this.cbSciFi.Size = new System.Drawing.Size(94, 30);
            this.cbSciFi.TabIndex = 1;
            this.cbSciFi.Text = "Sci-Fi";
            this.cbSciFi.UseVisualStyleBackColor = true;
            // 
            // cbDrama
            // 
            this.cbDrama.AutoSize = true;
            this.cbDrama.Location = new System.Drawing.Point(16, 31);
            this.cbDrama.Name = "cbDrama";
            this.cbDrama.Size = new System.Drawing.Size(104, 30);
            this.cbDrama.TabIndex = 0;
            this.cbDrama.Text = "Drama";
            this.cbDrama.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 596);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Production Year (YYYY)";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(356, 591);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 31);
            this.txtYear.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbNC17);
            this.groupBox2.Controls.Add(this.rbR);
            this.groupBox2.Controls.Add(this.rbPG13);
            this.groupBox2.Controls.Add(this.rbPG);
            this.groupBox2.Controls.Add(this.rbG);
            this.groupBox2.Location = new System.Drawing.Point(60, 829);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rating";
            // 
            // rbNC17
            // 
            this.rbNC17.AutoSize = true;
            this.rbNC17.ForeColor = System.Drawing.Color.Blue;
            this.rbNC17.Location = new System.Drawing.Point(398, 49);
            this.rbNC17.Name = "rbNC17";
            this.rbNC17.Size = new System.Drawing.Size(100, 30);
            this.rbNC17.TabIndex = 4;
            this.rbNC17.TabStop = true;
            this.rbNC17.Text = "NC-17";
            this.rbNC17.UseVisualStyleBackColor = true;
            // 
            // rbR
            // 
            this.rbR.AutoSize = true;
            this.rbR.ForeColor = System.Drawing.Color.Red;
            this.rbR.Location = new System.Drawing.Point(322, 49);
            this.rbR.Name = "rbR";
            this.rbR.Size = new System.Drawing.Size(53, 30);
            this.rbR.TabIndex = 3;
            this.rbR.TabStop = true;
            this.rbR.Text = "R";
            this.rbR.UseVisualStyleBackColor = true;
            // 
            // rbPG13
            // 
            this.rbPG13.AutoSize = true;
            this.rbPG13.ForeColor = System.Drawing.Color.DarkViolet;
            this.rbPG13.Location = new System.Drawing.Point(194, 48);
            this.rbPG13.Name = "rbPG13";
            this.rbPG13.Size = new System.Drawing.Size(100, 30);
            this.rbPG13.TabIndex = 2;
            this.rbPG13.TabStop = true;
            this.rbPG13.Text = "PG-13";
            this.rbPG13.UseVisualStyleBackColor = true;
            // 
            // rbPG
            // 
            this.rbPG.AutoSize = true;
            this.rbPG.ForeColor = System.Drawing.Color.DarkOrange;
            this.rbPG.Location = new System.Drawing.Point(103, 48);
            this.rbPG.Name = "rbPG";
            this.rbPG.Size = new System.Drawing.Size(69, 30);
            this.rbPG.TabIndex = 1;
            this.rbPG.TabStop = true;
            this.rbPG.Text = "PG";
            this.rbPG.UseVisualStyleBackColor = true;
            // 
            // rbG
            // 
            this.rbG.AutoSize = true;
            this.rbG.ForeColor = System.Drawing.Color.DarkCyan;
            this.rbG.Location = new System.Drawing.Point(27, 49);
            this.rbG.Name = "rbG";
            this.rbG.Size = new System.Drawing.Size(54, 30);
            this.rbG.TabIndex = 0;
            this.rbG.TabStop = true;
            this.rbG.Text = "G";
            this.rbG.UseVisualStyleBackColor = true;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(208, 80);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(248, 31);
            this.txtDirector.TabIndex = 11;
            // 
            // lbCast
            // 
            this.lbCast.FormattingEnabled = true;
            this.lbCast.ItemHeight = 25;
            this.lbCast.Location = new System.Drawing.Point(208, 186);
            this.lbCast.Name = "lbCast";
            this.lbCast.Size = new System.Drawing.Size(248, 129);
            this.lbCast.TabIndex = 12;
            // 
            // txtCast
            // 
            this.txtCast.Location = new System.Drawing.Point(208, 135);
            this.txtCast.Name = "txtCast";
            this.txtCast.Size = new System.Drawing.Size(248, 31);
            this.txtCast.TabIndex = 13;
            // 
            // btnAddCast
            // 
            this.btnAddCast.Location = new System.Drawing.Point(477, 131);
            this.btnAddCast.Name = "btnAddCast";
            this.btnAddCast.Size = new System.Drawing.Size(100, 39);
            this.btnAddCast.TabIndex = 14;
            this.btnAddCast.Text = "Add";
            this.btnAddCast.UseVisualStyleBackColor = true;
            this.btnAddCast.Click += new System.EventHandler(this.btnAddCast_Click);
            // 
            // btnDeleteCast
            // 
            this.btnDeleteCast.Location = new System.Drawing.Point(477, 276);
            this.btnDeleteCast.Name = "btnDeleteCast";
            this.btnDeleteCast.Size = new System.Drawing.Size(100, 39);
            this.btnDeleteCast.TabIndex = 15;
            this.btnDeleteCast.Text = "Delete";
            this.btnDeleteCast.UseVisualStyleBackColor = true;
            this.btnDeleteCast.Click += new System.EventHandler(this.btnDeleteCast_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Poster Image";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(477, 391);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 39);
            this.btnBrowse.TabIndex = 18;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(208, 391);
            this.txtImage.Name = "txtImage";
            this.txtImage.ReadOnly = true;
            this.txtImage.Size = new System.Drawing.Size(248, 123);
            this.txtImage.TabIndex = 19;
            this.txtImage.Text = "";
            // 
            // MovieBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(638, 1067);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDeleteCast);
            this.Controls.Add(this.btnAddCast);
            this.Controls.Add(this.txtCast);
            this.Controls.Add(this.lbCast);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MovieBase";
            this.Text = "MovieManipulate";
            this.Load += new System.EventHandler(this.MovieManipulate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddCast;
        private System.Windows.Forms.Button btnDeleteCast;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBrowse;
        protected System.Windows.Forms.Button btnSave;
        protected System.Windows.Forms.TextBox txtTitle;
        protected System.Windows.Forms.CheckBox cbThriller;
        protected System.Windows.Forms.CheckBox cbAction;
        protected System.Windows.Forms.CheckBox cbSciFi;
        protected System.Windows.Forms.CheckBox cbDrama;
        protected System.Windows.Forms.TextBox txtYear;
        protected System.Windows.Forms.RadioButton rbNC17;
        protected System.Windows.Forms.RadioButton rbR;
        protected System.Windows.Forms.RadioButton rbPG13;
        protected System.Windows.Forms.RadioButton rbPG;
        protected System.Windows.Forms.RadioButton rbG;
        protected System.Windows.Forms.TextBox txtDirector;
        protected System.Windows.Forms.ListBox lbCast;
        protected System.Windows.Forms.TextBox txtCast;
        protected System.Windows.Forms.RichTextBox txtImage;
    }
}