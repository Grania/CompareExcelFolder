using System;

namespace CEF_Core
{
	public class CEF_File
	{
		public string name { get { return _name; } }

		public string path { get { return CEF_Util.GetPathFromFullPath(this._fullPath); } }

		public string fullPath { get { return _fullPath; } }

		public string ext { get { return _ext; } }

		public long size { get { return _size; } }

		private string _name { get; set; }

		private string _fullPath { get; set; }

		private string _ext { get; set; }

		private long _size { get; set; }

		public CEF_File(CEF_File file)
		{
			this._name = file.name;
			this._fullPath = file.fullPath;
			this._ext = file.ext;
			this._size = file.size;
		}

		public CEF_File(string name, string fullPath, string ext, long size)
		{
			this._name = name;
			this._fullPath = fullPath;
			this._ext = ext;
			this._size = size;
		}

		public CEF_File(string fullPath)
		{
			this._name = CEF_Util.GetFileName(fullPath);
			this._fullPath = fullPath;
			this._ext = CEF_Util.GetFileExt(fullPath);
		}

		public bool isEqualContent(CEF_File file)
		{
			if (this._size != file._size)
				return false;

			var file1 = new System.IO.FileInfo(this._fullPath);
			var file2 = new System.IO.FileInfo(file._fullPath);

			using (System.IO.FileStream fs1 = file1.OpenRead())
			using (System.IO.FileStream fs2 = file2.OpenRead())
			{
				int f1Byte;
				int f2Byte;

				do
				{
					f1Byte = fs1.ReadByte();
					f2Byte = fs2.ReadByte();

					if (f1Byte != f2Byte)
						return false;
				} while (f1Byte != -1);
			}

			return true;
		}

		public bool isType(Type type)
		{
			if ((_ext == "xls") || (_ext == "xlsx"))
			{
				return type == typeof(CEF_Excel);
			}
			else if (_ext == ".pdf")
			{
				return type == typeof(CEF_Excel);
			}

			return false;
		}
	}
}

