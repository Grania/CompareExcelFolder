using System.Collections.Generic;

namespace CEF_Core
{
	public class CEF_ExcelCompareResult : CEF_Result<CEF_SheetChange>
	{
		
	}

	public class CEF_SheetChange
	{
		public string name { get; set; }
		List<KeyValuePair<int, int>> changePosition;

		public CEF_SheetChange(string name)
		{
			this.name = name;
			changePosition = new List<KeyValuePair<int, int>>();
		}

		public void addChange(int col, int row)
		{
			changePosition.Add(new KeyValuePair<int, int>(col, row));
		}
	}
}
