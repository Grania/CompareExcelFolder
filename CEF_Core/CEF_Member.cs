using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CEF_Core
{
	public class CEF_Member
	{
		public string name { get { return this._name; } }

		public Color color { get { return this._color; } }

		private string _name;

		private Color _color;

		public CEF_Member(string name, Color color)
		{
			this._name = name;
			this._color = color;
		}
	}
}
