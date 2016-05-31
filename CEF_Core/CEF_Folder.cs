using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CEF_Core
{
	public class CEF_Folder
	{
		public string name{ get; }
		public string path { get; }

		Dictionary<string, CEF_File> fileDic;

		public CEF_Folder (string path)
		{
			fileDic = new Dictionary<string, CEF_File> ();

			try {
				string[] strFiles = Directory.GetFiles (path);
				foreach (string strFile in strFiles) {
					string fileName = CEF_Util.GetFileName (strFile);

					if (fileDic.ContainsKey (fileName)) {
						throw new Exception ("Duplicate file name");
					}

					string fileExt = CEF_Util.GetFileExt (fileName);
					long size = (new FileInfo (strFile)).Length;

					fileDic.Add (fileName, new CEF_File (fileName, strFile, fileExt, size));
					this.path = path;
				}
			} catch (Exception ex) {
				throw ex;
			}
		}

		public CEF_CompareResult Compare (CEF_Folder oldFolder)
		{
			CEF_CompareResult result = new CEF_CompareResult ();

			foreach (KeyValuePair<string, CEF_File> thisFile in fileDic) {
				string fileName = thisFile.Key;
				CEF_File file = thisFile.Value;

				if (oldFolder.fileDic.ContainsKey (fileName)) {
					if (file.isEqualContent (oldFolder.GetFile (fileName))) {
						result.stillShape (file);
					} else {
						result.modified (file);
					}

					oldFolder.fileDic.Remove (fileName);
				} else {
					result.added (file);
				}
			}

			if (oldFolder.fileDic.Count > 0) {
				foreach (KeyValuePair<string, CEF_File> deleted in oldFolder.fileDic) {
					result.deleted (deleted.Value);
				}
			}

			return result;
		}

		public bool ContainFile (string fileName)
		{
			return this.fileDic.ContainsKey (fileName);
		}

		public CEF_File GetFile (string fileName)
		{
			return this.fileDic [fileName];
		}

		public List<string> GetSortedFileNameList ()
		{
			List<string> fileNames = fileDic.Keys.ToList ();
			fileNames.Sort ();

			return fileNames;
		}
	}
}

