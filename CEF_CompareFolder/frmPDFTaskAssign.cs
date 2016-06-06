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

		public frmPDFTaskAssign()
		{
			InitializeComponent();
			string pdfFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\pdf.pdf";
			CEF_PDF pdf = new CEF_PDF(new CEF_File(pdfFilePath));

			CEF_Member member1 = new CEF_Member("Member 1", Color.AliceBlue);
			CEF_Member member2 = new CEF_Member("Member 2", Color.AntiqueWhite);
			taskBuilder = new CEF_PFD_Task_Builder(pdf);

			taskBuilder.addMember(member2);
			taskBuilder.addMember(member1);

			taskBuilder.addTask(1, 1, member1);
			taskBuilder.addTask(3, 3, member1);
			taskBuilder.addTask(2, 2, member2);
			taskBuilder.addTask(4, 4, member2);

			taskBuilder.RenderPDFFileForMembers();
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			taskBuilder.MergePDFFile();
		}
	}
}
