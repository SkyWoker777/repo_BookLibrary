namespace LibraryApp
{
    partial class EditNewspaperForm
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
            this.dtpPostedOn = new System.Windows.Forms.DateTimePicker();
            this.labelErrName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelErrCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpPostedOn
            // 
            this.dtpPostedOn.Location = new System.Drawing.Point(11, 98);
            this.dtpPostedOn.Name = "dtpPostedOn";
            this.dtpPostedOn.Size = new System.Drawing.Size(210, 20);
            this.dtpPostedOn.TabIndex = 27;
            // 
            // labelErrName
            // 
            this.labelErrName.AutoSize = true;
            this.labelErrName.ForeColor = System.Drawing.Color.Red;
            this.labelErrName.Location = new System.Drawing.Point(53, 39);
            this.labelErrName.Name = "labelErrName";
            this.labelErrName.Size = new System.Drawing.Size(0, 13);
            this.labelErrName.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Change the fields to edit newspaper.";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(145, 170);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 25);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Posted On:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(11, 55);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(210, 20);
            this.tbxName.TabIndex = 19;
            // 
            // tbxCost
            // 
            this.tbxCost.Location = new System.Drawing.Point(11, 147);
            this.tbxCost.Name = "tbxCost";
            this.tbxCost.Size = new System.Drawing.Size(88, 20);
            this.tbxCost.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Cost:";
            // 
            // labelErrCost
            // 
            this.labelErrCost.AutoSize = true;
            this.labelErrCost.ForeColor = System.Drawing.Color.Red;
            this.labelErrCost.Location = new System.Drawing.Point(52, 131);
            this.labelErrCost.Name = "labelErrCost";
            this.labelErrCost.Size = new System.Drawing.Size(0, 13);
            this.labelErrCost.TabIndex = 30;
            // 
            // EditNewspaperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 207);
            this.Controls.Add(this.labelErrCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxCost);
            this.Controls.Add(this.dtpPostedOn);
            this.Controls.Add(this.labelErrName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxName);
            this.Name = "EditNewspaperForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpPostedOn;
        private System.Windows.Forms.Label labelErrName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelErrCost;
    }
}