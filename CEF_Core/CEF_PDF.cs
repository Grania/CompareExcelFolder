using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using System.IO;

namespace CEF_Core
{
	public class CEF_PDF : CEF_File
	{
		public int numberOfPage { get { return this._numberOfPage; } }

		private int _numberOfPage { get; set; }

		public CEF_PDF(CEF_File file)
			: base(file)
		{
			if (file.isType(typeof(CEF_PDF)))
				throw new Exception("File is not PDF");

			PdfReader reader;
			try
			{
				reader = new PdfReader(this.fullPath);
			}
			catch (Exception ex)
			{
				throw ex;
			}

			this._numberOfPage = reader.NumberOfPages;
		}

		public void RenderFilePDF(int from, int to, string desFullPath)
		{
			PdfReader reader;
			try
			{
				reader = new PdfReader(this.fullPath);
			}
			catch (Exception ex)
			{
				throw ex;
			}


		}

		private FileStream CreateFile(string desFullPath)
		{
			FileStream fs = new FileStream(desFullPath, FileMode.Create, FileAccess.Write, FileShare.None);
			return fs;
		}

		public FileStream SetMetaData(CEF_PDF master, FileStream fs)
		{
			PdfReader masterReader;
			PdfStamper stamper;

			try
			{
				masterReader = new PdfReader(master.fullPath);
				stamper = new PdfStamper(masterReader, fs);
			}
			catch (Exception ex)
			{
				throw ex;
			}

			Dictionary<String, String> info = masterReader.Info;
			stamper.MoreInfo = info;

			return fs;
		}

		public void CopyPage(CEF_PDF master, FileStream fs)
		{

		}
	}
}
