using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CEF_Core
{
	public class CEF_Excel
	{
		public CEF_Excel(CEF_File file)
		{
			if (!file.isExcel())
				throw new Exception("File is not Excel.");
		}

		public CEF_ExcelCompareResult Compare(CEF_Excel oldExcel)
		{
			return null;
		}
	}
}
