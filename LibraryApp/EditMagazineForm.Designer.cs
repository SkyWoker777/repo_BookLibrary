namespace LibraryApp
{
    partial class EditMagazineForm
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
            this.labelErrName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxLang = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.dtpPublished = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxCost = new System.Windows.Forms.TextBox();
            this.labelErrCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelErrName
            // 
            this.labelErrName.AutoSize = true;
            this.labelErrName.ForeColor = System.Drawing.Color.Red;
            this.labelErrName.Location = new System.Drawing.Point(53, 39);
            this.labelErrName.Name = "labelErrName";
            this.labelErrName.Size = new System.Drawing.Size(0, 13);
            this.labelErrName.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Change the fields to edit magazine.";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(146, 234);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 25);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Published:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Language:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name:";
            // 
            // tbxLang
            // 
            this.tbxLang.Location = new System.Drawing.Point(11, 104);
            this.tbxLang.Name = "tbxLang";
            this.tbxLang.Size = new System.Drawing.Size(210, 20);
            this.tbxLang.TabIndex = 10;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(11, 55);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(210, 20);
            this.tbxName.TabIndex = 9;
            // 
            // dtpPublished
            // 
            this.dtpPublished.Location = new System.Drawing.Point(11, 150);
            this.dtpPublished.Name = "dtpPublished";
            this.dtpPublished.Size = new System.Drawing.Size(210, 20);
            this.dtpPublished.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cost:";
            // 
            // tbxCost
            // 
            this.tbxCost.Location = new System.Drawing.Point(11, 199);
            this.tbxCost.Name = "tbxCost";
            this.tbxCost.Size = new System.Drawing.Size(96, 20);
            this.tbxCost.TabIndex = 20;
            // 
            // labelErrCost
            // 
            this.labelErrCost.AutoSize = true;
            this.labelErrCost.ForeColor = System.Drawing.Color.Red;
            this.labelErrCost.Location = new System.Drawing.Point(49, 183);
            this.labelErrCost.Name = "labelErrCost";
            this.labelErrCost.Size = new System.Drawing.Size(0, 13);
            this.labelErrCost.TabIndex = 21;
            // 
            // EditMagazineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 271);
            this.Controls.Add(this.labelErrCost);
            this.Controls.Add(this.tbxCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpPublished);
            this.Controls.Add(this.labelErrName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxLang);
            this.Controls.Add(this.tbxName);
            this.Name = "EditMagazineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelErrName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxLang;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.DateTimePicker dtpPublished;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxCost;
        private System.Windows.Forms.Label labelErrCost;
    }
}