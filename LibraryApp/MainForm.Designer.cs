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
            this.tabPageMagazines = new System.Windows.Forms.TabPage();
            this.tabPageNewspapers = new System.Windows.Forms.TabPage();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxAuthor = new System.Windows.Forms.TextBox();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(505, 452);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageBooks
            // 
            this.tabPageBooks.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageBooks.Controls.Add(this.button2);
            this.tabPageBooks.Controls.Add(this.groupBox1);
            this.tabPageBooks.Controls.Add(this.dgvBooks);
            this.tabPageBooks.Location = new System.Drawing.Point(4, 22);
            this.tabPageBooks.Name = "tabPageBooks";
            this.tabPageBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBooks.Size = new System.Drawing.Size(497, 426);
            this.tabPageBooks.TabIndex = 0;
            this.tabPageBooks.Text = "Books";
            // 
            // tabPageMagazines
            // 
            this.tabPageMagazines.Location = new System.Drawing.Point(4, 22);
            this.tabPageMagazines.Name = "tabPageMagazines";
            this.tabPageMagazines.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMagazines.Size = new System.Drawing.Size(497, 425);
            this.tabPageMagazines.TabIndex = 1;
            this.tabPageMagazines.Text = "Magazines";
            this.tabPageMagazines.UseVisualStyleBackColor = true;
            // 
            // tabPageNewspapers
            // 
            this.tabPageNewspapers.Location = new System.Drawing.Point(4, 22);
            this.tabPageNewspapers.Name = "tabPageNewspapers";
            this.tabPageNewspapers.Size = new System.Drawing.Size(497, 425);
            this.tabPageNewspapers.TabIndex = 2;
            this.tabPageNewspapers.Text = "Newspapers";
            this.tabPageNewspapers.UseVisualStyleBackColor = true;
            // 
            // dgvBooks
            // 
            this.dgvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBooks.BackgroundColor = System.Drawing.Color.White;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(0, 0);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(497, 230);
            this.dgvBooks.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxYear);
            this.groupBox1.Controls.Add(this.tbxAuthor);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Location = new System.Drawing.Point(6, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Book";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(6, 44);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(195, 20);
            this.tbxName.TabIndex = 0;
            // 
            // tbxAuthor
            // 
            this.tbxAuthor.Location = new System.Drawing.Point(7, 96);
            this.tbxAuthor.Name = "tbxAuthor";
            this.tbxAuthor.Size = new System.Drawing.Size(194, 20);
            this.tbxAuthor.TabIndex = 1;
            // 
            // tbxYear
            // 
            this.tbxYear.Location = new System.Drawing.Point(7, 148);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(100, 20);
            this.tbxYear.TabIndex = 2;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Author";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(409, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 499);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPageBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBooks;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.TextBox tbxAuthor;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.TabPage tabPageMagazines;
        private System.Windows.Forms.TabPage tabPageNewspapers;
    }
}