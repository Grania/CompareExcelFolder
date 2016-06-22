using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEF_Core;

namespace CEF_CompareFolder
{
	public partial class frmPDFTaskAssign : Form
	{
		CEF_PFD_Task_Builder taskBuilder;
		CEF_Member selectedMember;
		Color[] colorArray = new Color[] { Color.Pink,
			Color.DarkGray,
			Color.Plum,
			Color.SkyBlue,
			Color.PeachPuff,
			Color.LightGreen,
			Color.Aqua,
			Color.PaleGreen,
			Color.MediumPurple,
			Color.Peru,
			Color.Lime,
			Color.Orchid,
			Color.Yellow,
			Color.Wheat,
			Color.Cyan,
			Color.Gold,
			Color.LightPink,
			Color.Lavender
		};

		// 1 <=> >>>>>>>>>>>>
		// -1 <=> <<<<<<<<<<<<
		int assignStatus = 0;

		private bool outOfColor = false;

		public frmPDFTaskAssign()
		{
			InitializeComponent();

			lblAssignStatus.Text = String.Empty;

			string pdfFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\pdf.pdf";
			CEF_PDF pdf = new CEF_PDF(new CEF_File(pdfFilePath));

			CEF_Member member1 = new CEF_Member("Member 1", Color.AliceBlue);
			CEF_Member member2 = new CEF_Member("Member 2", Color.AntiqueWhite);
			taskBuilder = new CEF_PFD_Task_Builder(pdf);

			//taskBuilder.addMember(member2);
			//taskBuilder.addMember(member1);

			//taskBuilder.addTask(1, 1, member1);
			//taskBuilder.addTask(3, 3, member1);
			//taskBuilder.addTask(2, 2, member2);
			//taskBuilder.addTask(4, 4, member2);

			//taskBuilder.RenderPDFFileForMembers();
			FillDgvPage();
			pnlColorPicker.BackColor = RollColor();
		}

		private Color RollColor()
		{
			int colorIndex = taskBuilder.MemberCount() % colorArray.Length;
			int nextTime = 0;

			if (!outOfColor)
			{
				while (!taskBuilder.hasColor(colorArray[colorIndex]))
				{
					nextTime++;
					colorIndex++;
					colorIndex = taskBuilder.MemberCount() & colorIndex;
					if (nextTime > colorArray.Length)
					{
						outOfColor = true;
						break;
					}
				}
			}

			return colorArray[colorIndex];
		}

		private void button1_Click(object sender, EventArgs e)
		{
			taskBuilder.MergePDFFile();
		}

		private void FillDgvPage()
		{
			dgvPages.Rows.Add(taskBuilder.numberOfPage - 1);
			for (int i = 0; i < dgvPages.Rows.Count; i++)
			{
				dgvPages.Rows[i].Cells["clmNo"].Value = (i + 1);
			}
		}

		private void pnlColorPicker_MouseDown(object sender, MouseEventArgs e)
		{
			colorDialog.ShowDialog();
			pnlColorPicker.BackColor = colorDialog.Color;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string newMemberName = txtNewMemberName.Text.Trim();
			if (String.IsNullOrEmpty(newMemberName))
			{
				MessageBox.Show("Hãy điền tên member.");
				return;
			}
			if (taskBuilder.ContainMember(newMemberName))
			{
				MessageBox.Show("Member đã tồn tại.");
				return;
			}

			dgvMembers.Rows.Add(1);
			DataGridViewRow lastRow = dgvMembers.Rows[dgvMembers.Rows.Count - 1];
			lastRow.Cells["clmName"].Value = newMemberName;
			lastRow.Cells["clmColor"].Style.BackColor = pnlColorPicker.BackColor;
			lastRow.Cells["clmDelete"].Value = "Delete";

			taskBuilder.addMember(newMemberName, pnlColorPicker.BackColor);
			txtNewMemberName.Text = String.Empty;
			pnlColorPicker.BackColor = RollColor();
		}

		private void btnAssign_Click(object sender, EventArgs e)
		{
			if(dgvPages.SelectedRows.Count == 0)
			{
				MessageBox.Show("Hãy chọn page để assign.");
				return;
			}

			assignStatus = 1;
		}

		private void btnTranslate_Click(object sender, EventArgs e)
		{
			if(dgvMembers.SelectedRows.Count == 0)
			{
				MessageBox.Show("Hãy chọn member sẽ dịch.");
				return;
			}

			assignStatus = -1;
		}
	}
}
