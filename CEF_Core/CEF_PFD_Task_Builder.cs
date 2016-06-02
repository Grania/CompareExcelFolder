using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEF_Core
{
	public class CEF_PFD_Task_Builder
	{
		public string fileName { get { return _pdf.name; } }

		private CEF_PDF _pdf;

		private Dictionary<string, CEF_Member> _member;

		private CEF_Member[] _taskList;

		public CEF_PFD_Task_Builder(CEF_PDF pdf)
		{
			_pdf = pdf;
			_member = new Dictionary<string, CEF_Member>();
			_taskList = new CEF_Member[_pdf.numberOfPage + 1];
		}

		public void addTask(int from, int to, string memberName)
		{
			if (!_member.ContainsKey(memberName))
				throw new Exception("In valid member.");

			if (from <= 0 || to > _taskList.Length - 1)
				throw new Exception("Invalid range.");

			if (isConflict(from, to, memberName))
				throw new Exception("Conflict task.");

			for (int i = from; i <= to; i++)
			{
				_taskList[i] = _member[memberName];
			}
		}

		private bool isConflict(int from, int to, string memberName)
		{
			for (int i = from; i <= to; i++)
			{
				if (_taskList[i] == null)
					continue;
				if (_taskList[i].name != memberName)
					return false;
			}
			return true;
		}

		public void RenderPDFFile(bool copyAllFlg, string path = null)
		{
			if (path == null)
				path = _pdf.path;

			HashSet<string> renderedMember = new HashSet<string>();
			for (int i = 1; i < _taskList.Length; i++)
			{
				if (_taskList[i] == null)
					continue;

				if (renderedMember.Contains(_taskList[i].name))
					continue;

				string newFileName = CEF_Util.AppendFileName(_pdf.name, " - " + _taskList[i].name);
				if (copyAllFlg)
				{
					CEF_Util.DuplicateFile(_pdf, newFileName);
				}
				else
				{

				}

				renderedMember.Add(_taskList[i].name);
			}
		}
	}
}
