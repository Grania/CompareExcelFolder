using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEF_CompareFolder
{
	public partial class frmExportChange : Form
	{
		private string _exportPath;
		Color highlightColor;

		public frmExportChange(string defaultPath)
		{
			InitializeComponent();
			this._exportPath = defaultPath;
			txtPath.Text = defaultPath;
			highlightColor = Color.Red;

			pnlColorPre.BackColor = highlightColor;
		}

		private void btnChangeColor_Click(object sender, EventArgs e)
		{
			DialogResult re = cd.ShowDialog();
			if(re == DialogResult.OK)
			{
				highlightColor = cd.Color;
				pnlColorPre.BackColor = cd.Color;
			}
		}

		private void btnChangePath_Click(object sender, EventArgs e)
		{

		}
	}
}
