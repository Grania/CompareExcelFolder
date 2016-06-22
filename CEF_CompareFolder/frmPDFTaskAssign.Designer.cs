namespace CEF_CompareFolder
{
	partial class frmPDFTaskAssign
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
			this.button1 = new System.Windows.Forms.Button();
			this.dgvPages = new System.Windows.Forms.DataGridView();
			this.clmNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmMemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvMembers = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNewMemberName = new System.Windows.Forms.TextBox();
			this.pnlColorPicker = new System.Windows.Forms.Panel();
			this.btnAdd = new System.Windows.Forms.Button();
			this.colorDialog = new System.Windows.Forms.ColorDialog();
			this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAssign = new System.Windows.Forms.Button();
			this.btnTranslate = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblAssignStatus = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvPages)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(593, 595);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dgvPages
			// 
			this.dgvPages.AllowUserToAddRows = false;
			this.dgvPages.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dgvPages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPages.ColumnHeadersVisible = false;
			this.dgvPages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNo,
            this.clmMemberName});
			this.dgvPages.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvPages.EnableHeadersVisualStyles = false;
			this.dgvPages.Location = new System.Drawing.Point(12, 25);
			this.dgvPages.Name = "dgvPages";
			this.dgvPages.ReadOnly = true;
			this.dgvPages.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dgvPages.RowHeadersVisible = false;
			this.dgvPages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPages.Size = new System.Drawing.Size(253, 593);
			this.dgvPages.TabIndex = 1;
			// 
			// clmNo
			// 
			this.clmNo.HeaderText = "No";
			this.clmNo.Name = "clmNo";
			this.clmNo.ReadOnly = true;
			this.clmNo.Width = 50;
			// 
			// clmMemberName
			// 
			this.clmMemberName.HeaderText = "Tên người dịch";
			this.clmMemberName.Name = "clmMemberName";
			this.clmMemberName.ReadOnly = true;
			this.clmMemberName.Width = 200;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Danh sách trang";
			// 
			// dgvMembers
			// 
			this.dgvMembers.AllowUserToAddRows = false;
			this.dgvMembers.AllowUserToResizeRows = false;
			this.dgvMembers.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMembers.ColumnHeadersVisible = false;
			this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clmColor,
            this.clmDelete});
			this.dgvMembers.Location = new System.Drawing.Point(365, 25);
			this.dgvMembers.MultiSelect = false;
			this.dgvMembers.Name = "dgvMembers";
			this.dgvMembers.ReadOnly = true;
			this.dgvMembers.RowHeadersVisible = false;
			this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMembers.Size = new System.Drawing.Size(303, 262);
			this.dgvMembers.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(362, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Danh sách thành viên\r\n";
			// 
			// txtNewMemberName
			// 
			this.txtNewMemberName.Location = new System.Drawing.Point(365, 293);
			this.txtNewMemberName.Name = "txtNewMemberName";
			this.txtNewMemberName.Size = new System.Drawing.Size(202, 20);
			this.txtNewMemberName.TabIndex = 5;
			// 
			// pnlColorPicker
			// 
			this.pnlColorPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlColorPicker.Location = new System.Drawing.Point(574, 293);
			this.pnlColorPicker.Name = "pnlColorPicker";
			this.pnlColorPicker.Size = new System.Drawing.Size(51, 20);
			this.pnlColorPicker.TabIndex = 6;
			this.pnlColorPicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlColorPicker_MouseDown);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(632, 293);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(36, 23);
			this.btnAdd.TabIndex = 7;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// clmName
			// 
			this.clmName.HeaderText = "clmName";
			this.clmName.Name = "clmName";
			this.clmName.ReadOnly = true;
			this.clmName.Width = 200;
			// 
			// clmColor
			// 
			this.clmColor.HeaderText = "clmColor";
			this.clmColor.Name = "clmColor";
			this.clmColor.ReadOnly = true;
			this.clmColor.Width = 50;
			// 
			// clmDelete
			// 
			this.clmDelete.HeaderText = "clmDelete";
			this.clmDelete.Name = "clmDelete";
			this.clmDelete.ReadOnly = true;
			this.clmDelete.Width = 50;
			// 
			// btnAssign
			// 
			this.btnAssign.Location = new System.Drawing.Point(272, 88);
			this.btnAssign.Name = "btnAssign";
			this.btnAssign.Size = new System.Drawing.Size(87, 45);
			this.btnAssign.TabIndex = 8;
			this.btnAssign.Text = "Giao cho >>>>>>>>>>";
			this.btnAssign.UseVisualStyleBackColor = true;
			this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
			// 
			// btnTranslate
			// 
			this.btnTranslate.Location = new System.Drawing.Point(272, 164);
			this.btnTranslate.Name = "btnTranslate";
			this.btnTranslate.Size = new System.Drawing.Size(87, 50);
			this.btnTranslate.TabIndex = 9;
			this.btnTranslate.Text = "Dịch trang <<<<<<<<<<";
			this.btnTranslate.UseVisualStyleBackColor = true;
			this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(365, 368);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(303, 221);
			this.richTextBox1.TabIndex = 10;
			this.richTextBox1.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(365, 349);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Tổng kết";
			// 
			// lblAssignStatus
			// 
			this.lblAssignStatus.AutoSize = true;
			this.lblAssignStatus.Location = new System.Drawing.Point(274, 43);
			this.lblAssignStatus.Name = "lblAssignStatus";
			this.lblAssignStatus.Size = new System.Drawing.Size(78, 13);
			this.lblAssignStatus.TabIndex = 12;
			this.lblAssignStatus.Text = "lblAssignStatus";
			// 
			// frmPDFTaskAssign
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(680, 630);
			this.Controls.Add(this.lblAssignStatus);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.btnTranslate);
			this.Controls.Add(this.btnAssign);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.pnlColorPicker);
			this.Controls.Add(this.txtNewMemberName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dgvMembers);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvPages);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmPDFTaskAssign";
			this.Text = "frmPDFTaskAssign";
			((System.ComponentModel.ISupportInitialize)(this.dgvPages)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dgvPages;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmNo;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmMemberName;
		private System.Windows.Forms.DataGridView dgvMembers;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNewMemberName;
		private System.Windows.Forms.Panel pnlColorPicker;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ColorDialog colorDialog;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmColor;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmDelete;
		private System.Windows.Forms.Button btnAssign;
		private System.Windows.Forms.Button btnTranslate;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblAssignStatus;
	}
}