using System.Collections.Generic;

namespace CEF_Core
{
	public abstract class CEF_Result<T>
	{
		private List<T> _stillShape { get; set; }
		private List<T> _modified { get; set; }
		private List<T> _deleted { get; set; }
		private List<T> _added { get; set; }

		public CEF_Result(){
			_stillShape = new List<T>();
			_modified = new List<T>();
			_deleted = new List<T>();
			_added = new List<T>();
		}

		public void stillShape(T file)
		{
			_stillShape.Add(file);
		}

		public void modified(T file)
		{
			_modified.Add(file);
		}

		public void deleted(T file)
		{
			_deleted.Add(file);
		}

		public void added(T file)
		{
			_added.Add(file);
		}

		/// <summary>
		/// s : still shape |
		/// m : modified |
		/// d : deleted |
		/// a : added
		/// </summary>
		/// <param name="order"></param>
		/// <returns></returns>
		public List<T> GetResult(string order)
		{
			List<T> result = new List<T>();

			for (int i = 0; i < order.Length; i++)
			{
				if (order[i] == 's')
					result.AddRange(_stillShape);
				else if (order[i] == 'm')
					result.AddRange(_modified);
				else if (order[i] == 'd')
					result.AddRange(_deleted);
				else if (order[i] == 'a')
					result.AddRange(_added);
			}

			return result;
		}
	}
}
