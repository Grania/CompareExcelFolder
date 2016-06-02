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
		public frmPDFTaskAssign()
		{
			InitializeComponent();
			CEF_PDF pdf = new CEF_PDF(new CEF_File("C:\\Users\\ANDONGNHI\\Desktop\\tap1.pdf"));

			CEF_Util.DuplicateFile(pdf, "a");
			int a = 0;
		}
	}
}
