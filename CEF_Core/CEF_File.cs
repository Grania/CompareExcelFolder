using System;

namespace CEF_Core
{
	public class CEF_File
	{
		public string name{ get; }

		public string fullPath { get; }

		public string ext{ get; }

		public long size{ get; }

		public CEF_File (string name, string fullPath, string ext, long size)
		{
			this.name = name;
			this.fullPath = fullPath;
			this.ext = ext;
			this.size = size;
		}

		public bool isEqualContent(CEF_File file){
			if (this.size != file.size)
				return false;

			var file1 = new System.IO.FileInfo (this.fullPath);
			var file2 = new System.IO.FileInfo (file.fullPath);

			using (System.IO.FileStream fs1 = file1.OpenRead ())
			using (System.IO.FileStream fs2 = file2.OpenRead ()) {
				int f1Byte;
				int f2Byte;

				do {
					f1Byte = fs1.ReadByte ();
					f2Byte = fs2.ReadByte ();

					if (f1Byte != f2Byte)
						return false;
				} while(f1Byte != -1);
			}

			return true;
		}

		public bool isExcel()
		{
			return (ext == "xls")
				|| (ext == "xlsx");
		}
	}
}

