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
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.tabPageMagazines = new System.Windows.Forms.TabPage();
            this.btnEditMag = new System.Windows.Forms.Button();
            this.btnDeleteMagazine = new System.Windows.Forms.Button();
            this.dgvMagazines = new System.Windows.Forms.DataGridView();
            this.tabPageNewspapers = new System.Windows.Forms.TabPage();
            this.btnEditNper = new System.Windows.Forms.Button();
            this.btnDeleteNewspaper = new System.Windows.Forms.Button();
            this.btnAddNewspaper = new System.Windows.Forms.Button();
            this.dgvNewspapers = new System.Windows.Forms.DataGridView();
            this.labelInfo = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddMagazine = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.tabPageMagazines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazines)).BeginInit();
            this.tabPageNewspapers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewspapers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageBooks);
            this.tabControl1.Controls.Add(this.tabPageMagazines);
            this.tabControl1.Controls.Add(this.tabPageNewspapers);
            this.tabControl1.Location = new System.Drawing.Point(0, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(505, 354);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageBooks
            // 
            this.tabPageBooks.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageBooks.Controls.Add(this.btnAddBook);
            this.tabPageBooks.Controls.Add(this.btnEditBook);
            this.tabPageBooks.Controls.Add(this.btnDeleteBook);
            this.tabPageBooks.Controls.Add(this.dgvBooks);
            this.tabPageBooks.Location = new System.Drawing.Point(4, 22);
            this.tabPageBooks.Name = "tabPageBooks";
            this.tabPageBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBooks.Size = new System.Drawing.Size(497, 328);
            this.tabPageBooks.TabIndex = 0;
            this.tabPageBooks.Text = "Books";
            // 
            // btnEditBook
            // 
            this.btnEditBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditBook.Location = new System.Drawing.Point(94, 22);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(80, 25);
            this.btnEditBook.TabIndex = 3;
            this.btnEditBook.Text = "Edit";
            this.btnEditBook.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteBook.Location = new System.Drawing.Point(411, 22);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(80, 25);
            this.btnDeleteBook.TabIndex = 2;
            this.btnDeleteBook.Text = "Delete";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(8, 22);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(80, 25);
            this.btnAddBook.TabIndex = 6;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.UseVisualStyleBackColor = true;
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AllowUserToOrderColumns = true;
            this.dgvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.BackgroundColor = System.Drawing.Color.White;
            this.dgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvBooks.Location = new System.Drawing.Point(0, 53);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(497, 275);
            this.dgvBooks.TabIndex = 0;
            // 
            // tabPageMagazines
            // 
            this.tabPageMagazines.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageMagazines.Controls.Add(this.btnEditMag);
            this.tabPageMagazines.Controls.Add(this.btnAddMagazine);
            this.tabPageMagazines.Controls.Add(this.btnDeleteMagazine);
            this.tabPageMagazines.Controls.Add(this.dgvMagazines);
            this.tabPageMagazines.Location = new System.Drawing.Point(4, 22);
            this.tabPageMagazines.Name = "tabPageMagazines";
            this.tabPageMagazines.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMagazines.Size = new System.Drawing.Size(497, 328);
            this.tabPageMagazines.TabIndex = 1;
            this.tabPageMagazines.Text = "Magazines";
            // 
            // btnEditMag
            // 
            this.btnEditMag.Location = new System.Drawing.Point(92, 22);
            this.btnEditMag.Name = "btnEditMag";
            this.btnEditMag.Size = new System.Drawing.Size(80, 25);
            this.btnEditMag.TabIndex = 4;
            this.btnEditMag.Text = "Edit";
            this.btnEditMag.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMagazine
            // 
            this.btnDeleteMagazine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteMagazine.Location = new System.Drawing.Point(409, 22);
            this.btnDeleteMagazine.Name = "btnDeleteMagazine";
            this.btnDeleteMagazine.Size = new System.Drawing.Size(80, 25);
            this.btnDeleteMagazine.TabIndex = 3;
            this.btnDeleteMagazine.Text = "Delete";
            this.btnDeleteMagazine.UseVisualStyleBackColor = true;
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
            this.dgvMagazines.Location = new System.Drawing.Point(0, 53);
            this.dgvMagazines.MultiSelect = false;
            this.dgvMagazines.Name = "dgvMagazines";
            this.dgvMagazines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMagazines.Size = new System.Drawing.Size(497, 275);
            this.dgvMagazines.TabIndex = 1;
            // 
            // tabPageNewspapers
            // 
            this.tabPageNewspapers.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageNewspapers.Controls.Add(this.btnEditNper);
            this.tabPageNewspapers.Controls.Add(this.btnAddNewspaper);
            this.tabPageNewspapers.Controls.Add(this.btnDeleteNewspaper);
            this.tabPageNewspapers.Controls.Add(this.dgvNewspapers);
            this.tabPageNewspapers.Location = new System.Drawing.Point(4, 22);
            this.tabPageNewspapers.Name = "tabPageNewspapers";
            this.tabPageNewspapers.Size = new System.Drawing.Size(497, 328);
            this.tabPageNewspapers.TabIndex = 2;
            this.tabPageNewspapers.Text = "Newspapers";
            // 
            // btnEditNper
            // 
            this.btnEditNper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditNper.Location = new System.Drawing.Point(94, 22);
            this.btnEditNper.Name = "btnEditNper";
            this.btnEditNper.Size = new System.Drawing.Size(80, 25);
            this.btnEditNper.TabIndex = 5;
            this.btnEditNper.Text = "Edit";
            this.btnEditNper.UseVisualStyleBackColor = true;
            // 
            // btnDeleteNewspaper
            // 
            this.btnDeleteNewspaper.Location = new System.Drawing.Point(409, 22);
            this.btnDeleteNewspaper.Name = "btnDeleteNewspaper";
            this.btnDeleteNewspaper.Size = new System.Drawing.Size(80, 25);
            this.btnDeleteNewspaper.TabIndex = 4;
            this.btnDeleteNewspaper.Text = "Delete";
            this.btnDeleteNewspaper.UseVisualStyleBackColor = true;
            // 
            // btnAddNewspaper
            // 
            this.btnAddNewspaper.Location = new System.Drawing.Point(8, 22);
            this.btnAddNewspaper.Name = "btnAddNewspaper";
            this.btnAddNewspaper.Size = new System.Drawing.Size(80, 25);
            this.btnAddNewspaper.TabIndex = 6;
            this.btnAddNewspaper.Text = "Add";
            this.btnAddNewspaper.UseVisualStyleBackColor = true;
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
            this.dgvNewspapers.Location = new System.Drawing.Point(0, 53);
            this.dgvNewspapers.MultiSelect = false;
            this.dgvNewspapers.Name = "dgvNewspapers";
            this.dgvNewspapers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNewspapers.Size = new System.Drawing.Size(497, 275);
            this.dgvNewspapers.TabIndex = 2;
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.Green;
            this.labelInfo.Location = new System.Drawing.Point(19, 416);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 18);
            this.labelInfo.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(413, 416);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 25);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddMagazine
            // 
            this.btnAddMagazine.Location = new System.Drawing.Point(6, 22);
            this.btnAddMagazine.Name = "btnAddMagazine";
            this.btnAddMagazine.Size = new System.Drawing.Size(80, 25);
            this.btnAddMagazine.TabIndex = 6;
            this.btnAddMagazine.Text = "Add";
            this.btnAddMagazine.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 451);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPageBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.tabPageMagazines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazines)).EndInit();
            this.tabPageNewspapers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewspapers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBooks;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.TabPage tabPageMagazines;
        private System.Windows.Forms.TabPage tabPageNewspapers;
        private System.Windows.Forms.DataGridView dgvMagazines;
        private System.Windows.Forms.Button btnDeleteMagazine;
        private System.Windows.Forms.Button btnAddNewspaper;
        private System.Windows.Forms.DataGridView dgvNewspapers;
        private System.Windows.Forms.Button btnDeleteNewspaper;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnEditMag;
        private System.Windows.Forms.Button btnEditNper;
        private System.Windows.Forms.Button btnAddMagazine;
    }
}