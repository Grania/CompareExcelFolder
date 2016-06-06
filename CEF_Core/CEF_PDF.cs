using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
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
	}
}
