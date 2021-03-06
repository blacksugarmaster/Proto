﻿namespace Proto.Forms
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lbLength = new System.Windows.Forms.Label();
            this.cbImage = new System.Windows.Forms.CheckBox();
            this.txtImage = new System.Windows.Forms.RichTextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteCast = new System.Windows.Forms.Button();
            this.btnAddCast = new System.Windows.Forms.Button();
            this.txtCast = new System.Windows.Forms.TextBox();
            this.lbCast = new System.Windows.Forms.ListBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAnimation5 = new System.Windows.Forms.CheckBox();
            this.cbHorror4 = new System.Windows.Forms.CheckBox();
            this.cbThriller3 = new System.Windows.Forms.CheckBox();
            this.cbAction2 = new System.Windows.Forms.CheckBox();
            this.cbSciFi0 = new System.Windows.Forms.CheckBox();
            this.cbDrama1 = new System.Windows.Forms.CheckBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNC17 = new System.Windows.Forms.RadioButton();
            this.rbR = new System.Windows.Forms.RadioButton();
            this.rbPG13 = new System.Windows.Forms.RadioButton();
            this.rbPG = new System.Windows.Forms.RadioButton();
            this.rbG = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 1032);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 100);
            this.panel1.TabIndex = 23;
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(366, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(192, 69);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(67, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(192, 69);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.pbPoster);
            this.panel2.Controls.Add(this.txtLength);
            this.panel2.Controls.Add(this.lbLength);
            this.panel2.Controls.Add(this.cbImage);
            this.panel2.Controls.Add(this.txtImage);
            this.panel2.Controls.Add(this.btnBrowse);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnDeleteCast);
            this.panel2.Controls.Add(this.btnAddCast);
            this.panel2.Controls.Add(this.txtCast);
            this.panel2.Controls.Add(this.lbCast);
            this.panel2.Controls.Add(this.txtDirector);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.txtTitle);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtYear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 1032);
            this.panel2.TabIndex = 25;
            // 
            // pbPoster
            // 
            this.pbPoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPoster.Location = new System.Drawing.Point(208, 385);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(248, 281);
            this.pbPoster.TabIndex = 44;
            this.pbPoster.TabStop = false;
            this.pbPoster.MouseHover += new System.EventHandler(this.Poster_Hover);
            // 
            // txtLength
            // 
            this.txtLength.AccessibleName = "Running Time";
            this.txtLength.Location = new System.Drawing.Point(208, 328);
            this.txtLength.MaxLength = 4;
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(248, 31);
            this.txtLength.TabIndex = 32;
            this.txtLength.Enter += new System.EventHandler(this.txtLength_Enter);
            this.txtLength.Validating += new System.ComponentModel.CancelEventHandler(this.validating_txtInt);
            // 
            // lbLength
            // 
            this.lbLength.AutoSize = true;
            this.lbLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLength.Location = new System.Drawing.Point(45, 328);
            this.lbLength.Name = "lbLength";
            this.lbLength.Size = new System.Drawing.Size(159, 26);
            this.lbLength.TabIndex = 43;
            this.lbLength.Text = "Running Time";
            // 
            // cbImage
            // 
            this.cbImage.AutoSize = true;
            this.cbImage.Location = new System.Drawing.Point(477, 477);
            this.cbImage.Name = "cbImage";
            this.cbImage.Size = new System.Drawing.Size(108, 30);
            this.cbImage.TabIndex = 42;
            this.cbImage.Text = "Include";
            this.cbImage.UseVisualStyleBackColor = true;
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(477, 535);
            this.txtImage.Name = "txtImage";
            this.txtImage.ReadOnly = true;
            this.txtImage.Size = new System.Drawing.Size(100, 61);
            this.txtImage.TabIndex = 41;
            this.txtImage.Text = "";
            this.txtImage.Visible = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(477, 385);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 39);
            this.btnBrowse.TabIndex = 33;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 26);
            this.label5.TabIndex = 40;
            this.label5.Text = "Poster Image";
            // 
            // btnDeleteCast
            // 
            this.btnDeleteCast.Location = new System.Drawing.Point(477, 270);
            this.btnDeleteCast.Name = "btnDeleteCast";
            this.btnDeleteCast.Size = new System.Drawing.Size(100, 39);
            this.btnDeleteCast.TabIndex = 39;
            this.btnDeleteCast.Text = "Delete";
            this.btnDeleteCast.UseVisualStyleBackColor = true;
            this.btnDeleteCast.Click += new System.EventHandler(this.btnDeleteCast_Click);
            // 
            // btnAddCast
            // 
            this.btnAddCast.Location = new System.Drawing.Point(477, 125);
            this.btnAddCast.Name = "btnAddCast";
            this.btnAddCast.Size = new System.Drawing.Size(100, 39);
            this.btnAddCast.TabIndex = 31;
            this.btnAddCast.Text = "Add";
            this.btnAddCast.UseVisualStyleBackColor = true;
            this.btnAddCast.Click += new System.EventHandler(this.btnAddCast_Click);
            // 
            // txtCast
            // 
            this.txtCast.Location = new System.Drawing.Point(208, 129);
            this.txtCast.MaxLength = 99;
            this.txtCast.Name = "txtCast";
            this.txtCast.Size = new System.Drawing.Size(248, 31);
            this.txtCast.TabIndex = 29;
            this.txtCast.Enter += new System.EventHandler(this.txtCast_Enter);
            // 
            // lbCast
            // 
            this.lbCast.FormattingEnabled = true;
            this.lbCast.ItemHeight = 25;
            this.lbCast.Location = new System.Drawing.Point(208, 180);
            this.lbCast.Name = "lbCast";
            this.lbCast.Size = new System.Drawing.Size(248, 129);
            this.lbCast.TabIndex = 38;
            // 
            // txtDirector
            // 
            this.txtDirector.AccessibleName = "Director";
            this.txtDirector.Location = new System.Drawing.Point(208, 74);
            this.txtDirector.MaxLength = 99;
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(248, 31);
            this.txtDirector.TabIndex = 28;
            this.txtDirector.Enter += new System.EventHandler(this.txtDirector_Enter);
            this.txtDirector.Validating += new System.ComponentModel.CancelEventHandler(this.validating_txt);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAnimation5);
            this.groupBox1.Controls.Add(this.cbHorror4);
            this.groupBox1.Controls.Add(this.cbThriller3);
            this.groupBox1.Controls.Add(this.cbAction2);
            this.groupBox1.Controls.Add(this.cbSciFi0);
            this.groupBox1.Controls.Add(this.cbDrama1);
            this.groupBox1.Location = new System.Drawing.Point(60, 739);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 155);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genre";
            // 
            // cbAnimation5
            // 
            this.cbAnimation5.AutoSize = true;
            this.cbAnimation5.Location = new System.Drawing.Point(127, 93);
            this.cbAnimation5.Name = "cbAnimation5";
            this.cbAnimation5.Size = new System.Drawing.Size(136, 30);
            this.cbAnimation5.TabIndex = 12;
            this.cbAnimation5.Text = "Animation";
            this.cbAnimation5.UseVisualStyleBackColor = true;
            // 
            // cbHorror4
            // 
            this.cbHorror4.AutoSize = true;
            this.cbHorror4.Location = new System.Drawing.Point(16, 94);
            this.cbHorror4.Name = "cbHorror4";
            this.cbHorror4.Size = new System.Drawing.Size(99, 30);
            this.cbHorror4.TabIndex = 11;
            this.cbHorror4.Text = "Horror";
            this.cbHorror4.UseVisualStyleBackColor = true;
            // 
            // cbThriller3
            // 
            this.cbThriller3.AutoSize = true;
            this.cbThriller3.Location = new System.Drawing.Point(369, 30);
            this.cbThriller3.Name = "cbThriller3";
            this.cbThriller3.Size = new System.Drawing.Size(103, 30);
            this.cbThriller3.TabIndex = 10;
            this.cbThriller3.Text = "Thriller";
            this.cbThriller3.UseVisualStyleBackColor = true;
            // 
            // cbAction2
            // 
            this.cbAction2.AutoSize = true;
            this.cbAction2.Location = new System.Drawing.Point(246, 30);
            this.cbAction2.Name = "cbAction2";
            this.cbAction2.Size = new System.Drawing.Size(99, 30);
            this.cbAction2.TabIndex = 9;
            this.cbAction2.Text = "Action";
            this.cbAction2.UseVisualStyleBackColor = true;
            // 
            // cbSciFi0
            // 
            this.cbSciFi0.AutoSize = true;
            this.cbSciFi0.Location = new System.Drawing.Point(16, 30);
            this.cbSciFi0.Name = "cbSciFi0";
            this.cbSciFi0.Size = new System.Drawing.Size(94, 30);
            this.cbSciFi0.TabIndex = 7;
            this.cbSciFi0.Text = "Sci-Fi";
            this.cbSciFi0.UseVisualStyleBackColor = true;
            // 
            // cbDrama1
            // 
            this.cbDrama1.AutoSize = true;
            this.cbDrama1.Location = new System.Drawing.Point(127, 30);
            this.cbDrama1.Name = "cbDrama1";
            this.cbDrama1.Size = new System.Drawing.Size(104, 30);
            this.cbDrama1.TabIndex = 8;
            this.cbDrama1.Text = "Drama";
            this.cbDrama1.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.AccessibleName = "Title";
            this.txtTitle.Location = new System.Drawing.Point(208, 20);
            this.txtTitle.MaxLength = 99;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(248, 31);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Enter += new System.EventHandler(this.txtTitle_Enter);
            this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.validating_txt);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 26);
            this.label3.TabIndex = 30;
            this.label3.Text = "Cast";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 27;
            this.label2.Text = "Director";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 26);
            this.label1.TabIndex = 25;
            this.label1.Text = "Title";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbNC17);
            this.groupBox2.Controls.Add(this.rbR);
            this.groupBox2.Controls.Add(this.rbPG13);
            this.groupBox2.Controls.Add(this.rbPG);
            this.groupBox2.Controls.Add(this.rbG);
            this.groupBox2.Location = new System.Drawing.Point(60, 900);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 100);
            this.groupBox2.TabIndex = 37;
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
            this.rbNC17.TabIndex = 17;
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
            this.rbR.TabIndex = 16;
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
            this.rbPG13.TabIndex = 15;
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
            this.rbPG.TabIndex = 14;
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
            this.rbG.TabIndex = 13;
            this.rbG.TabStop = true;
            this.rbG.Text = "G";
            this.rbG.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 684);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 26);
            this.label4.TabIndex = 36;
            this.label4.Text = "Year (YYYY)";
            // 
            // txtYear
            // 
            this.txtYear.AccessibleName = "Year";
            this.txtYear.Location = new System.Drawing.Point(208, 681);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(248, 31);
            this.txtYear.TabIndex = 34;
            this.txtYear.Enter += new System.EventHandler(this.txtYear_Enter);
            this.txtYear.Validating += new System.ComponentModel.CancelEventHandler(this.validating_txtInt);
            // 
            // ep
            // 
            this.ep.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ep.ContainerControl = this;
            // 
            // MovieBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(636, 1132);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MovieBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieManipulate";
            this.Load += new System.EventHandler(this.MovieBase_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Button btnCancel;
        protected System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbPoster;
        protected System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lbLength;
        protected System.Windows.Forms.CheckBox cbImage;
        protected System.Windows.Forms.RichTextBox txtImage;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteCast;
        private System.Windows.Forms.Button btnAddCast;
        protected System.Windows.Forms.TextBox txtCast;
        protected System.Windows.Forms.ListBox lbCast;
        protected System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.CheckBox cbAnimation5;
        protected System.Windows.Forms.CheckBox cbHorror4;
        protected System.Windows.Forms.CheckBox cbThriller3;
        protected System.Windows.Forms.CheckBox cbAction2;
        protected System.Windows.Forms.CheckBox cbSciFi0;
        protected System.Windows.Forms.CheckBox cbDrama1;
        protected System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.RadioButton rbNC17;
        protected System.Windows.Forms.RadioButton rbR;
        protected System.Windows.Forms.RadioButton rbPG13;
        protected System.Windows.Forms.RadioButton rbPG;
        protected System.Windows.Forms.RadioButton rbG;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox txtYear;
        public System.Windows.Forms.ErrorProvider ep;
    }
}