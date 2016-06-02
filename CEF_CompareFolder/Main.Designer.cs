namespace CEF_CompareFolder
{
    partial class Main
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
			this.btnSelectOldFld = new System.Windows.Forms.Button();
			this.txtOldFldPath = new System.Windows.Forms.TextBox();
			this.txtNewFldPath = new System.Windows.Forms.TextBox();
			this.btnSelectNewFld = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.fbdOld = new System.Windows.Forms.FolderBrowserDialog();
			this.fbdNew = new System.Windows.Forms.FolderBrowserDialog();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblOldLoaded = new System.Windows.Forms.Label();
			this.lblNewLoaded = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btnExpChange = new System.Windows.Forms.Button();
			this.txtStillShape = new System.Windows.Forms.RichTextBox();
			this.txtModified = new System.Windows.Forms.RichTextBox();
			this.txtDeleted = new System.Windows.Forms.RichTextBox();
			this.txtAdded = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// btnSelectOldFld
			// 
			this.btnSelectOldFld.Location = new System.Drawing.Point(12, 32);
			this.btnSelectOldFld.Name = "btnSelectOldFld";
			this.btnSelectOldFld.Size = new System.Drawing.Size(75, 23);
			this.btnSelectOldFld.TabIndex = 0;
			this.btnSelectOldFld.Text = "Chọn";
			this.btnSelectOldFld.UseVisualStyleBackColor = true;
			this.btnSelectOldFld.Click += new System.EventHandler(this.btnSelectOldFld_Click);
			// 
			// txtOldFldPath
			// 
			this.txtOldFldPath.Location = new System.Drawing.Point(93, 33);
			this.txtOldFldPath.Name = "txtOldFldPath";
			this.txtOldFldPath.Size = new System.Drawing.Size(369, 20);
			this.txtOldFldPath.TabIndex = 1;
			// 
			// txtNewFldPath
			// 
			this.txtNewFldPath.Location = new System.Drawing.Point(93, 93);
			this.txtNewFldPath.Name = "txtNewFldPath";
			this.txtNewFldPath.Size = new System.Drawing.Size(369, 20);
			this.txtNewFldPath.TabIndex = 3;
			// 
			// btnSelectNewFld
			// 
			this.btnSelectNewFld.Location = new System.Drawing.Point(12, 92);
			this.btnSelectNewFld.Name = "btnSelectNewFld";
			this.btnSelectNewFld.Size = new System.Drawing.Size(75, 23);
			this.btnSelectNewFld.TabIndex = 2;
			this.btnSelectNewFld.Text = "Chọn";
			this.btnSelectNewFld.UseVisualStyleBackColor = true;
			this.btnSelectNewFld.Click += new System.EventHandler(this.btnSelectNewFld_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Folder cũ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Folder mới";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 138);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Vẫn vậy";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 320);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Cái này mới";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(262, 138);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(101, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Có thay đổi mới nhé";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(262, 320);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(121, 13);
			this.label6.TabIndex = 9;
			this.label6.Text = "Những cái này bị xóa rồi";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(13, 505);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(112, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Phiên bản: 0.0000001";
			// 
			// lblOldLoaded
			// 
			this.lblOldLoaded.AutoSize = true;
			this.lblOldLoaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOldLoaded.ForeColor = System.Drawing.Color.Green;
			this.lblOldLoaded.Location = new System.Drawing.Point(465, 36);
			this.lblOldLoaded.Name = "lblOldLoaded";
			this.lblOldLoaded.Size = new System.Drawing.Size(49, 13);
			this.lblOldLoaded.TabIndex = 15;
			this.lblOldLoaded.Text = "Loaded";
			// 
			// lblNewLoaded
			// 
			this.lblNewLoaded.AutoSize = true;
			this.lblNewLoaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNewLoaded.ForeColor = System.Drawing.Color.Green;
			this.lblNewLoaded.Location = new System.Drawing.Point(465, 98);
			this.lblNewLoaded.Name = "lblNewLoaded";
			this.lblNewLoaded.Size = new System.Drawing.Size(49, 13);
			this.lblNewLoaded.TabIndex = 16;
			this.lblNewLoaded.Text = "Loaded";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(412, 505);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(102, 13);
			this.label8.TabIndex = 17;
			this.label8.Text = "Created by: dungnm\r\n";
			// 
			// btnExpChange
			// 
			this.btnExpChange.Location = new System.Drawing.Point(404, 132);
			this.btnExpChange.Name = "btnExpChange";
			this.btnExpChange.Size = new System.Drawing.Size(92, 23);
			this.btnExpChange.TabIndex = 18;
			this.btnExpChange.Text = "Export thay đổi";
			this.btnExpChange.UseVisualStyleBackColor = true;
			this.btnExpChange.Click += new System.EventHandler(this.btnExpChange_Click);
			// 
			// txtStillShape
			// 
			this.txtStillShape.Location = new System.Drawing.Point(12, 155);
			this.txtStillShape.Name = "txtStillShape";
			this.txtStillShape.Size = new System.Drawing.Size(235, 151);
			this.txtStillShape.TabIndex = 19;
			this.txtStillShape.Text = "";
			// 
			// txtModified
			// 
			this.txtModified.Location = new System.Drawing.Point(265, 155);
			this.txtModified.Name = "txtModified";
			this.txtModified.Size = new System.Drawing.Size(235, 151);
			this.txtModified.TabIndex = 20;
			this.txtModified.Text = "";
			// 
			// txtDeleted
			// 
			this.txtDeleted.Location = new System.Drawing.Point(261, 336);
			this.txtDeleted.Name = "txtDeleted";
			this.txtDeleted.Size = new System.Drawing.Size(235, 151);
			this.txtDeleted.TabIndex = 21;
			this.txtDeleted.Text = "";
			// 
			// txtAdded
			// 
			this.txtAdded.Location = new System.Drawing.Point(12, 336);
			this.txtAdded.Name = "txtAdded";
			this.txtAdded.Size = new System.Drawing.Size(235, 151);
			this.txtAdded.TabIndex = 22;
			this.txtAdded.Text = "";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(518, 527);
			this.Controls.Add(this.txtAdded);
			this.Controls.Add(this.txtDeleted);
			this.Controls.Add(this.txtModified);
			this.Controls.Add(this.txtStillShape);
			this.Controls.Add(this.btnExpChange);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.lblNewLoaded);
			this.Controls.Add(this.lblOldLoaded);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNewFldPath);
			this.Controls.Add(this.btnSelectNewFld);
			this.Controls.Add(this.txtOldFldPath);
			this.Controls.Add(this.btnSelectOldFld);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Main";
			this.Text = "So sánh 2 folder";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelectOldFld;
        private System.Windows.Forms.TextBox txtOldFldPath;
        private System.Windows.Forms.TextBox txtNewFldPath;
        private System.Windows.Forms.Button btnSelectNewFld;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog fbdOld;
        private System.Windows.Forms.FolderBrowserDialog fbdNew;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblOldLoaded;
		private System.Windows.Forms.Label lblNewLoaded;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnExpChange;
		private System.Windows.Forms.RichTextBox txtStillShape;
		private System.Windows.Forms.RichTextBox txtModified;
		private System.Windows.Forms.RichTextBox txtDeleted;
		private System.Windows.Forms.RichTextBox txtAdded;
	}
}

