namespace LibraryApp
{
    partial class AddMagazineForm
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
            this.labelErrName = new System.Windows.Forms.Label();
            this.dtpPublished = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxLang = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnAddMagazine = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelErrCost = new System.Windows.Forms.Label();
            this.tbxCost = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxCost);
            this.groupBox1.Controls.Add(this.labelErrCost);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelErrName);
            this.groupBox1.Controls.Add(this.dtpPublished);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxLang);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 219);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New magazine";
            // 
            // labelErrName
            // 
            this.labelErrName.AutoSize = true;
            this.labelErrName.ForeColor = System.Drawing.Color.Red;
            this.labelErrName.Location = new System.Drawing.Point(57, 31);
            this.labelErrName.Name = "labelErrName";
            this.labelErrName.Size = new System.Drawing.Size(0, 13);
            this.labelErrName.TabIndex = 8;
            // 
            // dtpPublished
            // 
            this.dtpPublished.Location = new System.Drawing.Point(12, 136);
            this.dtpPublished.Name = "dtpPublished";
            this.dtpPublished.Size = new System.Drawing.Size(195, 20);
            this.dtpPublished.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Published:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Language:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // tbxLang
            // 
            this.tbxLang.Location = new System.Drawing.Point(12, 91);
            this.tbxLang.Name = "tbxLang";
            this.tbxLang.Size = new System.Drawing.Size(195, 20);
            this.tbxLang.TabIndex = 1;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(12, 47);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(195, 20);
            this.tbxName.TabIndex = 0;
            // 
            // btnAddMagazine
            // 
            this.btnAddMagazine.Location = new System.Drawing.Point(155, 237);
            this.btnAddMagazine.Name = "btnAddMagazine";
            this.btnAddMagazine.Size = new System.Drawing.Size(80, 25);
            this.btnAddMagazine.TabIndex = 6;
            this.btnAddMagazine.Text = "Add";
            this.btnAddMagazine.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cost:";
            // 
            // labelErrCost
            // 
            this.labelErrCost.AutoSize = true;
            this.labelErrCost.ForeColor = System.Drawing.Color.Red;
            this.labelErrCost.Location = new System.Drawing.Point(50, 167);
            this.labelErrCost.Name = "labelErrCost";
            this.labelErrCost.Size = new System.Drawing.Size(0, 13);
            this.labelErrCost.TabIndex = 10;
            // 
            // tbxCost
            // 
            this.tbxCost.Location = new System.Drawing.Point(12, 183);
            this.tbxCost.Name = "tbxCost";
            this.tbxCost.Size = new System.Drawing.Size(76, 20);
            this.tbxCost.TabIndex = 11;
            // 
            // AddMagazineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 270);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddMagazine);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(263, 309);
            this.Name = "AddMagazineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpPublished;
        private System.Windows.Forms.Button btnAddMagazine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxLang;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label labelErrName;
        private System.Windows.Forms.TextBox tbxCost;
        private System.Windows.Forms.Label labelErrCost;
        private System.Windows.Forms.Label label4;
    }
}