using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace CEF_Core
{
	public class CEF_Excel : CEF_File
	{
		private Excel.Workbook workBook { get; set; }

		public CEF_Excel(CEF_File file)
			:base(file.name, file.fullPath, file.ext, file.size)
		{
			if (!file.isType(typeof(CEF_Excel)))
				throw new Exception("File is not Excel.");

			Excel.Application excelApp = new Excel.Application();

			try
			{
				this.workBook = excelApp.Workbooks.Open(file.fullPath);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public CEF_ExcelCompareResult Compare(CEF_Excel oldExcel)
		{
			CEF_ExcelCompareResult result = new CEF_ExcelCompareResult();
			HashSet<string> newSheet = SheetNameToHashSet(this.workBook);
			HashSet<string> oldSheet = SheetNameToHashSet(oldExcel.workBook);

			foreach (string sheetName in newSheet)
			{
				if (oldSheet.Contains(sheetName))
					CompareSheet((Excel.Worksheet)this.workBook.Worksheets[""],
						(Excel.Worksheet)oldExcel.workBook.Worksheets[sheetName],
						result);
				else
					result.added(new CEF_SheetChange(sheetName));
			}

			return null;
		}

		private CEF_SheetChange CompareSheet(Excel.Worksheet newSheet, Excel.Worksheet oldSheet,
			CEF_ExcelCompareResult result)
		{

			return null;
		}

		private HashSet<string> SheetNameToHashSet(Excel.Workbook workBook)
		{
			HashSet<string> sheetName = new HashSet<string>();

			foreach (Excel.Worksheet sheet in workBook.Worksheets)
			{
				sheetName.Add(sheet.Name);
			}

			return sheetName;
		}
	}
}
