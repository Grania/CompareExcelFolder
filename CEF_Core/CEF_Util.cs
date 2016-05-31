using System;

namespace CEF_Core
{
	public static class CEF_Util
	{
		public static string GetFileExt (string fileName)
		{
			for (int i = fileName.Length - 1; i >= 0; i--) {
				if (fileName [i] == '.') {
					return fileName.Substring (i + 1);
				}
			}

			return String.Empty;
		}

		public static string GetFileName (string path)
		{
			for (int i = path.Length - 1; i >= 0; i--) {
				if (path [i] == '\\' || path [i] == '/') {
					return path.Substring (i + 1);
				}
			}

			return String.Empty;
		}
	}
}

