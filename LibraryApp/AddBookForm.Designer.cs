namespace LibraryApp
{
    partial class AddBookForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelErrCost = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxBookCost = new System.Windows.Forms.TextBox();
            this.labelErrYear = new System.Windows.Forms.Label();
            this.labelErrName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxYearBook = new System.Windows.Forms.TextBox();
            this.tbxAuthorBook = new System.Windows.Forms.TextBox();
            this.tbxNameBook = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelErrCost);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxBookCost);
            this.groupBox1.Controls.Add(this.labelErrYear);
            this.groupBox1.Controls.Add(this.labelErrName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxYearBook);
            this.groupBox1.Controls.Add(this.tbxAuthorBook);
            this.groupBox1.Controls.Add(this.tbxNameBook);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 195);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New book";
            // 
            // labelErrCost
            // 
            this.labelErrCost.AutoSize = true;
            this.labelErrCost.ForeColor = System.Drawing.Color.Red;
            this.labelErrCost.Location = new System.Drawing.Point(147, 140);
            this.labelErrCost.Name = "labelErrCost";
            this.labelErrCost.Size = new System.Drawing.Size(0, 13);
            this.labelErrCost.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cost:";
            // 
            // tbxBookCost
            // 
            this.tbxBookCost.Location = new System.Drawing.Point(119, 156);
            this.tbxBookCost.Name = "tbxBookCost";
            this.tbxBookCost.Size = new System.Drawing.Size(87, 20);
            this.tbxBookCost.TabIndex = 9;
            // 
            // labelErrYear
            // 
            this.labelErrYear.AutoSize = true;
            this.labelErrYear.ForeColor = System.Drawing.Color.Red;
            this.labelErrYear.Location = new System.Drawing.Point(44, 140);
            this.labelErrYear.Name = "labelErrYear";
            this.labelErrYear.Size = new System.Drawing.Size(0, 13);
            this.labelErrYear.TabIndex = 8;
            // 
            // labelErrName
            // 
            this.labelErrName.AutoSize = true;
            this.labelErrName.ForeColor = System.Drawing.Color.Red;
            this.labelErrName.Location = new System.Drawing.Point(54, 33);
            this.labelErrName.Name = "labelErrName";
            this.labelErrName.Size = new System.Drawing.Size(0, 13);
            this.labelErrName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Author:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // tbxYearBook
            // 
            this.tbxYearBook.Location = new System.Drawing.Point(12, 156);
            this.tbxYearBook.MaxLength = 4;
            this.tbxYearBook.Name = "tbxYearBook";
            this.tbxYearBook.Size = new System.Drawing.Size(61, 20);
            this.tbxYearBook.TabIndex = 2;
            // 
            // tbxAuthorBook
            // 
            this.tbxAuthorBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAuthorBook.Location = new System.Drawing.Point(12, 104);
            this.tbxAuthorBook.Name = "tbxAuthorBook";
            this.tbxAuthorBook.Size = new System.Drawing.Size(194, 20);
            this.tbxAuthorBook.TabIndex = 1;
            // 
            // tbxNameBook
            // 
            this.tbxNameBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxNameBook.Location = new System.Drawing.Point(11, 52);
            this.tbxNameBook.Name = "tbxNameBook";
            this.tbxNameBook.Size = new System.Drawing.Size(195, 20);
            this.tbxNameBook.TabIndex = 0;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBook.Location = new System.Drawing.Point(149, 216);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(80, 25);
            this.btnAddBook.TabIndex = 6;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.UseVisualStyleBackColor = true;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 253);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddBook);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(257, 292);
            this.MinimumSize = new System.Drawing.Size(136, 292);
            this.Name = "AddBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxYearBook;
        private System.Windows.Forms.TextBox tbxAuthorBook;
        private System.Windows.Forms.TextBox tbxNameBook;
        private System.Windows.Forms.Label labelErrName;
        private System.Windows.Forms.Label labelErrYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxBookCost;
        private System.Windows.Forms.Label labelErrCost;
    }
}