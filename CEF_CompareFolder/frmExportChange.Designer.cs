namespace CEF_CompareFolder
{
	partial class frmExportChange
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExportChange));
			this.label1 = new System.Windows.Forms.Label();
			this.btnChangePath = new System.Windows.Forms.Button();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.fbd = new System.Windows.Forms.FolderBrowserDialog();
			this.cd = new System.Windows.Forms.ColorDialog();
			this.pnlColorPre = new System.Windows.Forms.Panel();
			this.btnChangeColor = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(655, 80);
			this.label1.TabIndex = 0;
			this.label1.Text = resources.GetString("label1.Text");
			// 
			// btnChangePath
			// 
			this.btnChangePath.Location = new System.Drawing.Point(16, 97);
			this.btnChangePath.Name = "btnChangePath";
			this.btnChangePath.Size = new System.Drawing.Size(125, 23);
			this.btnChangePath.TabIndex = 1;
			this.btnChangePath.Text = "Thay đổi vị trí export";
			this.btnChangePath.UseVisualStyleBackColor = true;
			this.btnChangePath.Click += new System.EventHandler(this.btnChangePath_Click);
			// 
			// txtPath
			// 
			this.txtPath.Location = new System.Drawing.Point(148, 99);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(508, 20);
			this.txtPath.TabIndex = 2;
			// 
			// pnlColorPre
			// 
			this.pnlColorPre.Location = new System.Drawing.Point(148, 134);
			this.pnlColorPre.Name = "pnlColorPre";
			this.pnlColorPre.Size = new System.Drawing.Size(118, 28);
			this.pnlColorPre.TabIndex = 3;
			// 
			// btnChangeColor
			// 
			this.btnChangeColor.Location = new System.Drawing.Point(16, 139);
			this.btnChangeColor.Name = "btnChangeColor";
			this.btnChangeColor.Size = new System.Drawing.Size(125, 23);
			this.btnChangeColor.TabIndex = 4;
			this.btnChangeColor.Text = "Chọn màu";
			this.btnChangeColor.UseVisualStyleBackColor = true;
			this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
			// 
			// frmExportChange
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(668, 262);
			this.Controls.Add(this.btnChangeColor);
			this.Controls.Add(this.pnlColorPre);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.btnChangePath);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmExportChange";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmExportChange";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnChangePath;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.FolderBrowserDialog fbd;
		private System.Windows.Forms.ColorDialog cd;
		private System.Windows.Forms.Panel pnlColorPre;
		private System.Windows.Forms.Button btnChangeColor;
	}
}