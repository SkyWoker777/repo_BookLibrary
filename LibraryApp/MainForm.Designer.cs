namespace LibraryApp
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBooks = new System.Windows.Forms.TabPage();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.tbxAuthor = new System.Windows.Forms.TextBox();
            this.tbxNameBook = new System.Windows.Forms.TextBox();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.tabPageMagazines = new System.Windows.Forms.TabPage();
            this.btn_DeleteMagazine = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp_Pablished = new System.Windows.Forms.DateTimePicker();
            this.btn_AddMagazine = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxLang = new System.Windows.Forms.TextBox();
            this.tbxNameMag = new System.Windows.Forms.TextBox();
            this.dgvMagazines = new System.Windows.Forms.DataGridView();
            this.tabPageNewspapers = new System.Windows.Forms.TabPage();
            this.btn_DeleteNewspaper = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtp_Posted = new System.Windows.Forms.DateTimePicker();
            this.btn_AddNewspaper = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxNameNews = new System.Windows.Forms.TextBox();
            this.dgvNewspapers = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageBooks.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.tabPageMagazines.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazines)).BeginInit();
            this.tabPageNewspapers.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewspapers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageBooks);
            this.tabControl1.Controls.Add(this.tabPageMagazines);
            this.tabControl1.Controls.Add(this.tabPageNewspapers);
            this.tabControl1.Location = new System.Drawing.Point(0, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(505, 470);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageBooks
            // 
            this.tabPageBooks.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageBooks.Controls.Add(this.btnDeleteBook);
            this.tabPageBooks.Controls.Add(this.groupBox1);
            this.tabPageBooks.Controls.Add(this.dgvBooks);
            this.tabPageBooks.Location = new System.Drawing.Point(4, 22);
            this.tabPageBooks.Name = "tabPageBooks";
            this.tabPageBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBooks.Size = new System.Drawing.Size(497, 444);
            this.tabPageBooks.TabIndex = 0;
            this.tabPageBooks.Text = "Books";
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteBook.Location = new System.Drawing.Point(409, 239);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(80, 25);
            this.btnDeleteBook.TabIndex = 2;
            this.btnDeleteBook.Text = "Delete";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btn_DeleteBook_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddBook);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxYear);
            this.groupBox1.Controls.Add(this.tbxAuthor);
            this.groupBox1.Controls.Add(this.tbxNameBook);
            this.groupBox1.Location = new System.Drawing.Point(8, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Book";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(132, 148);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(80, 25);
            this.btnAddBook.TabIndex = 6;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btn_AddBook_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // tbxYear
            // 
            this.tbxYear.Location = new System.Drawing.Point(7, 148);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(100, 20);
            this.tbxYear.TabIndex = 2;
            // 
            // tbxAuthor
            // 
            this.tbxAuthor.Location = new System.Drawing.Point(7, 96);
            this.tbxAuthor.Name = "tbxAuthor";
            this.tbxAuthor.Size = new System.Drawing.Size(194, 20);
            this.tbxAuthor.TabIndex = 1;
            // 
            // tbxNameBook
            // 
            this.tbxNameBook.Location = new System.Drawing.Point(6, 44);
            this.tbxNameBook.Name = "tbxNameBook";
            this.tbxNameBook.Size = new System.Drawing.Size(195, 20);
            this.tbxNameBook.TabIndex = 0;
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.BackgroundColor = System.Drawing.Color.White;
            this.dgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvBooks.Location = new System.Drawing.Point(3, 3);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(491, 230);
            this.dgvBooks.TabIndex = 0;
            // 
            // tabPageMagazines
            // 
            this.tabPageMagazines.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageMagazines.Controls.Add(this.btn_DeleteMagazine);
            this.tabPageMagazines.Controls.Add(this.groupBox2);
            this.tabPageMagazines.Controls.Add(this.dgvMagazines);
            this.tabPageMagazines.Location = new System.Drawing.Point(4, 22);
            this.tabPageMagazines.Name = "tabPageMagazines";
            this.tabPageMagazines.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMagazines.Size = new System.Drawing.Size(497, 444);
            this.tabPageMagazines.TabIndex = 1;
            this.tabPageMagazines.Text = "Magazines";
            // 
            // btn_DeleteMagazine
            // 
            this.btn_DeleteMagazine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeleteMagazine.Location = new System.Drawing.Point(409, 239);
            this.btn_DeleteMagazine.Name = "btn_DeleteMagazine";
            this.btn_DeleteMagazine.Size = new System.Drawing.Size(80, 25);
            this.btn_DeleteMagazine.TabIndex = 3;
            this.btn_DeleteMagazine.Text = "Delete";
            this.btn_DeleteMagazine.UseVisualStyleBackColor = true;
            this.btn_DeleteMagazine.Click += new System.EventHandler(this.btn_DeleteMagazine_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_Pablished);
            this.groupBox2.Controls.Add(this.btn_AddMagazine);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbxLang);
            this.groupBox2.Controls.Add(this.tbxNameMag);
            this.groupBox2.Location = new System.Drawing.Point(6, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 183);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Magazine";
            // 
            // dtp_Pablished
            // 
            this.dtp_Pablished.Location = new System.Drawing.Point(6, 143);
            this.dtp_Pablished.Name = "dtp_Pablished";
            this.dtp_Pablished.Size = new System.Drawing.Size(127, 20);
            this.dtp_Pablished.TabIndex = 4;
            // 
            // btn_AddMagazine
            // 
            this.btn_AddMagazine.Location = new System.Drawing.Point(159, 152);
            this.btn_AddMagazine.Name = "btn_AddMagazine";
            this.btn_AddMagazine.Size = new System.Drawing.Size(80, 25);
            this.btn_AddMagazine.TabIndex = 6;
            this.btn_AddMagazine.Text = "Add";
            this.btn_AddMagazine.UseVisualStyleBackColor = true;
            this.btn_AddMagazine.Click += new System.EventHandler(this.btn_AddMagazine_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Language:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Published:";
            // 
            // tbxLang
            // 
            this.tbxLang.Location = new System.Drawing.Point(6, 96);
            this.tbxLang.Name = "tbxLang";
            this.tbxLang.Size = new System.Drawing.Size(194, 20);
            this.tbxLang.TabIndex = 1;
            // 
            // tbxNameMag
            // 
            this.tbxNameMag.Location = new System.Drawing.Point(6, 44);
            this.tbxNameMag.Name = "tbxNameMag";
            this.tbxNameMag.Size = new System.Drawing.Size(195, 20);
            this.tbxNameMag.TabIndex = 0;
            // 
            // dgvMagazines
            // 
            this.dgvMagazines.AllowUserToAddRows = false;
            this.dgvMagazines.AllowUserToDeleteRows = false;
            this.dgvMagazines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMagazines.BackgroundColor = System.Drawing.Color.White;
            this.dgvMagazines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMagazines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMagazines.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvMagazines.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMagazines.Location = new System.Drawing.Point(3, 3);
            this.dgvMagazines.MultiSelect = false;
            this.dgvMagazines.Name = "dgvMagazines";
            this.dgvMagazines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMagazines.Size = new System.Drawing.Size(491, 230);
            this.dgvMagazines.TabIndex = 1;
            // 
            // tabPageNewspapers
            // 
            this.tabPageNewspapers.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageNewspapers.Controls.Add(this.btn_DeleteNewspaper);
            this.tabPageNewspapers.Controls.Add(this.groupBox3);
            this.tabPageNewspapers.Controls.Add(this.dgvNewspapers);
            this.tabPageNewspapers.Location = new System.Drawing.Point(4, 22);
            this.tabPageNewspapers.Name = "tabPageNewspapers";
            this.tabPageNewspapers.Size = new System.Drawing.Size(497, 444);
            this.tabPageNewspapers.TabIndex = 2;
            this.tabPageNewspapers.Text = "Newspapers";
            // 
            // btn_DeleteNewspaper
            // 
            this.btn_DeleteNewspaper.Location = new System.Drawing.Point(409, 236);
            this.btn_DeleteNewspaper.Name = "btn_DeleteNewspaper";
            this.btn_DeleteNewspaper.Size = new System.Drawing.Size(80, 25);
            this.btn_DeleteNewspaper.TabIndex = 4;
            this.btn_DeleteNewspaper.Text = "Delete";
            this.btn_DeleteNewspaper.UseVisualStyleBackColor = true;
            this.btn_DeleteNewspaper.Click += new System.EventHandler(this.btn_DeleteNewspaper_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtp_Posted);
            this.groupBox3.Controls.Add(this.btn_AddNewspaper);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbxNameNews);
            this.groupBox3.Location = new System.Drawing.Point(8, 252);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 179);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Newspaper";
            // 
            // dtp_Posted
            // 
            this.dtp_Posted.Location = new System.Drawing.Point(6, 92);
            this.dtp_Posted.Name = "dtp_Posted";
            this.dtp_Posted.Size = new System.Drawing.Size(127, 20);
            this.dtp_Posted.TabIndex = 4;
            // 
            // btn_AddNewspaper
            // 
            this.btn_AddNewspaper.Location = new System.Drawing.Point(159, 148);
            this.btn_AddNewspaper.Name = "btn_AddNewspaper";
            this.btn_AddNewspaper.Size = new System.Drawing.Size(80, 25);
            this.btn_AddNewspaper.TabIndex = 6;
            this.btn_AddNewspaper.Text = "Add";
            this.btn_AddNewspaper.UseVisualStyleBackColor = true;
            this.btn_AddNewspaper.Click += new System.EventHandler(this.btn_AddNewspaper_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Posted On:";
            // 
            // tbxNameNews
            // 
            this.tbxNameNews.Location = new System.Drawing.Point(6, 44);
            this.tbxNameNews.Name = "tbxNameNews";
            this.tbxNameNews.Size = new System.Drawing.Size(186, 20);
            this.tbxNameNews.TabIndex = 0;
            // 
            // dgvNewspapers
            // 
            this.dgvNewspapers.AllowUserToAddRows = false;
            this.dgvNewspapers.AllowUserToDeleteRows = false;
            this.dgvNewspapers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNewspapers.BackgroundColor = System.Drawing.Color.White;
            this.dgvNewspapers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNewspapers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewspapers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvNewspapers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvNewspapers.Location = new System.Drawing.Point(0, 0);
            this.dgvNewspapers.MultiSelect = false;
            this.dgvNewspapers.Name = "dgvNewspapers";
            this.dgvNewspapers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNewspapers.Size = new System.Drawing.Size(497, 230);
            this.dgvNewspapers.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(413, 524);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 25);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 561);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPageBooks.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.tabPageMagazines.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazines)).EndInit();
            this.tabPageNewspapers.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewspapers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBooks;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.TextBox tbxAuthor;
        private System.Windows.Forms.TextBox tbxNameBook;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.TabPage tabPageMagazines;
        private System.Windows.Forms.TabPage tabPageNewspapers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_AddMagazine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxLang;
        private System.Windows.Forms.TextBox tbxNameMag;
        private System.Windows.Forms.DataGridView dgvMagazines;
        private System.Windows.Forms.Button btn_DeleteMagazine;
        private System.Windows.Forms.DateTimePicker dtp_Pablished;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtp_Posted;
        private System.Windows.Forms.Button btn_AddNewspaper;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxNameNews;
        private System.Windows.Forms.DataGridView dgvNewspapers;
        private System.Windows.Forms.Button btn_DeleteNewspaper;
        private System.Windows.Forms.Button btnExit;
    }
}