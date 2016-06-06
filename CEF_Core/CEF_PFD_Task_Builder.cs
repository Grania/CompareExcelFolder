using System;
using System.Collections.Generic;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text;

namespace CEF_Core
{
	public class CEF_PFD_Task_Builder
	{
		private const string _masterMemberName = "____master_____aowiehf";

		public string fileName { get { return _pdf.name; } }

		private CEF_PDF _pdf;

		private Dictionary<string, CEF_Member> _member;

		HashSet<string> _renderedMemberName;

		private CEF_Member[] _taskList;

		public CEF_PFD_Task_Builder(CEF_PDF pdf)
		{
			_pdf = pdf;
			_member = new Dictionary<string, CEF_Member>();
			_taskList = new CEF_Member[_pdf.numberOfPage + 1];
		}

		public void addMember(string memberName, System.Drawing.Color color)
		{
			this.addMember(new CEF_Member(memberName, color));
		}

		public void addMember(CEF_Member member)
		{
			if (_member.ContainsKey(member.name))
				throw new Exception("This member already added.");

			_member.Add(member.name, member);
		}

		public void addTask(int from, int to, string memberName)
		{
			if (!_member.ContainsKey(memberName))
				throw new Exception("In valid member.");

			addTask(from, to, _member[memberName]);
		}

		public void addTask(int from, int to, CEF_Member member)
		{
			if (!_member.ContainsKey(member.name))
				throw new Exception("In valid member.");

			if (from <= 0 || to > _taskList.Length - 1)
				throw new Exception("Invalid range.");

			if (isConflict(from, to, member.name))
				throw new Exception("Conflict task.");

			for (int i = from; i <= to; i++)
			{
				_taskList[i] = member;
			}
		}

		private bool isConflict(int from, int to, string memberName)
		{
			for (int i = from; i <= to; i++)
			{
				if (_taskList[i] == null)
					continue;
				if (_taskList[i].name != memberName)
					return true;
			}
			return false;
		}

		public void RenderPDFFileForMembers(string path = null)
		{
			if (path == null)
				path = _pdf.path;

			_renderedMemberName = new HashSet<string>();
			for (int i = 1; i < _taskList.Length; i++)
			{
				if (_taskList[i] == null)
					continue;

				if (_renderedMemberName.Contains(_taskList[i].name))
					continue;

				CEF_Util.DuplicateFile(_pdf, getFullPathForMemberName(_taskList[i].name));

				_renderedMemberName.Add(_taskList[i].name);
			}
		}

		public void MergePDFFile()
		{
			try
			{
				//Dictionary<string, PdfReader> dicReader = getAllPdfReader();
				
				//dicReader.Add(_masterMemberName, masterReader);

				string mergedFullFilePath = _pdf.path + "\\(MERGED)" + _pdf.name;
				FileStream outFileStream = new FileStream(mergedFullFilePath, FileMode.Create, FileAccess.Write);
				PdfConcatenate outFileConcat = new PdfConcatenate(outFileStream);

				int from = 1;
				int to = 1;
				string memberName = null;
				for (int i = 1; i < _taskList.Length; i++)
				{
					string tempMemberName;
					if (_taskList[i] == null)
						tempMemberName = _masterMemberName;
					else
						tempMemberName = _taskList[i].name;

					if(memberName == null)
					{
						from = i;
						to = i;
						memberName = tempMemberName;
						continue;
					}

					if(memberName == tempMemberName)
						to++;
					else
					{
						CopyPage(from, to, memberName, outFileConcat);
						memberName = tempMemberName;
						from = i;
						to = i;
					}
				}
				CopyPage(from, to, memberName, outFileConcat);

				outFileConcat.Close();
				//CloseAllStream(dicReader);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		private Dictionary<string, List<int>> getPagesNeededDic()
		{
			Dictionary<string, List<int>> re = new Dictionary<string, List<int>>();
			re.Add(_masterMemberName, new List<int>());

			foreach (string memberName in _renderedMemberName)
				re.Add(memberName, new List<int>());

			for (int i = 1; i < _taskList.Length; i++)
			{
				if (_taskList[i] == null)
					continue;
				re[_taskList[i].name].Add(i);
			}

			return re;
		}

		private void CopyPage(int from, int to, string memberName, PdfConcatenate outFileConcat)
		{
			List<int> re = new List<int>();
			for(int i = from; i <= to; i++)
				re.Add(i);

			PdfReader pdfReader;
			if(memberName == _masterMemberName)
				pdfReader = new PdfReader(_pdf.fullPath);
			else
				pdfReader = new PdfReader(getFullPathForMemberName(memberName));

			this.CopyPage(re, pdfReader, outFileConcat);
		}

		private void CopyPage(List<int> neededPages, PdfReader pdfReader, PdfConcatenate outFileConcat)
		{
			if (neededPages.Count == 0)
				return;

			pdfReader.SelectPages(neededPages);
			outFileConcat.AddPages(pdfReader);
			pdfReader.Close();
		}

		private List<int> getNeedePageList(string memberName)
		{
			List<int> re = new List<int>();

			for (int i = 1; i < _taskList.Length; i++)
			{
				if (_taskList[i] == null)
					continue;
				if(_taskList[i].name == memberName)
				{
					re.Add(i);
				}
			}

			return re;
		}

		private Dictionary<string, PdfReader> getAllPdfReader()
		{
			Dictionary<string, PdfReader> re = new Dictionary<string, PdfReader>();

			try
			{
				foreach (string memberName in _renderedMemberName)
				{
					PdfReader reader = new PdfReader(getFullPathForMemberName(memberName));
					re.Add(memberName, reader);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}

			return re;
		}

		private void CloseAllStream(Dictionary<string, PdfReader> dic)
		{
			foreach (var reader in dic)
				reader.Value.Close();
		}

		private string getFileNameForMemberName(string memberName)
		{
			return CEF_Util.AppendFileName(_pdf.name, " - " + memberName);
		}

		private string getFullPathForMemberName(string memberName)
		{
			return _pdf.path + "\\" + getFileNameForMemberName(memberName);
		}
	}
}
