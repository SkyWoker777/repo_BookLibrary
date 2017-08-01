namespace LibraryApp
{
    partial class AddNewspaperForm
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
            this.dtpPostedOn = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnAddNewsp = new System.Windows.Forms.Button();
            this.tbxCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelErrCost = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelErrCost);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxCost);
            this.groupBox1.Controls.Add(this.labelErrName);
            this.groupBox1.Controls.Add(this.dtpPostedOn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 188);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New newspaper";
            // 
            // labelErrName
            // 
            this.labelErrName.AutoSize = true;
            this.labelErrName.ForeColor = System.Drawing.Color.Red;
            this.labelErrName.Location = new System.Drawing.Point(61, 36);
            this.labelErrName.Name = "labelErrName";
            this.labelErrName.Size = new System.Drawing.Size(0, 13);
            this.labelErrName.TabIndex = 8;
            // 
            // dtpPostedOn
            // 
            this.dtpPostedOn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPostedOn.Location = new System.Drawing.Point(16, 99);
            this.dtpPostedOn.Name = "dtpPostedOn";
            this.dtpPostedOn.Size = new System.Drawing.Size(195, 20);
            this.dtpPostedOn.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Posted On:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // tbxName
            // 
            this.tbxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxName.Location = new System.Drawing.Point(16, 52);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(195, 20);
            this.tbxName.TabIndex = 0;
            // 
            // btnAddNewsp
            // 
            this.btnAddNewsp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewsp.Location = new System.Drawing.Point(158, 206);
            this.btnAddNewsp.Name = "btnAddNewsp";
            this.btnAddNewsp.Size = new System.Drawing.Size(80, 25);
            this.btnAddNewsp.TabIndex = 6;
            this.btnAddNewsp.Text = "Add";
            this.btnAddNewsp.UseVisualStyleBackColor = true;
            // 
            // tbxCost
            // 
            this.tbxCost.Location = new System.Drawing.Point(16, 151);
            this.tbxCost.Name = "tbxCost";
            this.tbxCost.Size = new System.Drawing.Size(82, 20);
            this.tbxCost.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cost:";
            // 
            // labelErrCost
            // 
            this.labelErrCost.AutoSize = true;
            this.labelErrCost.ForeColor = System.Drawing.Color.Red;
            this.labelErrCost.Location = new System.Drawing.Point(54, 135);
            this.labelErrCost.Name = "labelErrCost";
            this.labelErrCost.Size = new System.Drawing.Size(0, 13);
            this.labelErrCost.TabIndex = 11;
            // 
            // AddNewspaperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 243);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddNewsp);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(266, 282);
            this.MinimumSize = new System.Drawing.Size(193, 282);
            this.Name = "AddNewspaperForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelErrName;
        private System.Windows.Forms.DateTimePicker dtpPostedOn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnAddNewsp;
        private System.Windows.Forms.Label labelErrCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCost;
    }
}