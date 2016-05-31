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

namespace CEF_Form
{
	public partial class Main : Form
	{
		protected CEF_Folder oldFolder;
		protected CEF_Folder newFolder;

		public Main()
		{
			InitializeComponent();
			lblNewLoaded.Visible = false;
			lblOldLoaded.Visible = false;

			oldFolder = new CEF_Folder("C:\\Users\\DungNM\\Desktop");
			newFolder = new CEF_Folder("C:\\Users\\DungNM\\Desktop");
			DisplayCompareResult();
		}

		private void btnSelectNewFld_Click(object sender, EventArgs e)
		{
			fbdNew.ShowDialog();
			if (!String.IsNullOrWhiteSpace(fbdNew.SelectedPath))
			{
				txtNewFldPath.Text = fbdNew.SelectedPath;
				newFolder = new CEF_Folder(fbdNew.SelectedPath);
				lblNewLoaded.Visible = true;
			}

			DisplayCompareResult();
		}

		private void btnSelectOldFld_Click(object sender, EventArgs e)
		{
			fbdOld.ShowDialog();
			if (!String.IsNullOrWhiteSpace(fbdOld.SelectedPath))
			{
				txtOldFldPath.Text = fbdOld.SelectedPath;
				oldFolder = new CEF_Folder(fbdOld.SelectedPath);
				lblOldLoaded.Visible = true;
			}

			DisplayCompareResult();
		}

		private void DisplayCompareResult()
		{
			if (oldFolder == null || newFolder == null)
				return;

			CEF_CompareResult result = newFolder.Compare(oldFolder);
			StringBuilder strRe = new StringBuilder();

			List<CEF_File> stillShape = result.GetResult("s");
			foreach (CEF_File file in stillShape)
			{
				strRe.Append(file.name);
				strRe.Append(Environment.NewLine);
			}
			txtStillShape.Text = strRe.ToString();

			strRe = new StringBuilder();
			List<CEF_File> added = result.GetResult("a");
			foreach (CEF_File file in added)
			{
				strRe.Append(file.name);
				strRe.Append(Environment.NewLine);
			}
			txtAdded.Text = strRe.ToString();

			strRe = new StringBuilder();
			List<CEF_File> modifed = result.GetResult("m");
			foreach (CEF_File file in modifed)
			{
				strRe.Append(file.name);
				strRe.Append(Environment.NewLine);
			}
			txtModified.Text = strRe.ToString();

			strRe = new StringBuilder();
			List<CEF_File> deleted = result.GetResult("d");
			foreach (CEF_File file in deleted)
			{
				strRe.Append(file.name);
				strRe.Append(Environment.NewLine);
			}
			txtDeleted.Text = strRe.ToString();
		}

		private void btnExpChange_Click(object sender, EventArgs e)
		{
			if (oldFolder == null || newFolder == null)
				return;

			using (var form = new frmExportChange(newFolder.path))
			{
				form.ShowDialog();
			}
		}
	}
}
