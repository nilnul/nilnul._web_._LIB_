using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._query
{
	/// <summary>
	/// a=b in a=b&c=d
	/// </summary>
	public class Entry
	{
		private _entry.Term _key;

		public _entry.Term key
		{
			get { return _key; }
			set { _key = value; }
		}

		private _entry.Term _val;

		public _entry.Term val
		{
			get { return _val; }
			set { _val = value; }
		}

		public Entry(_entry.Term key, _entry.Term val)
		{
			_key = key;
			_val = val;
		}
		public override string ToString()
		{
			return $"{key}={val}";
		}

		static public Entry Parse(string s) {
			string normalized;
			if (s.Contains(_entry.Punctuators.SEPARATOR) )
			{
				normalized = s;

			}
			else
			{
				normalized = "=" + s;
			}
			return _Parse(normalized);
		}

		static public Entry _Parse(string _containSeparator) {
			var split = _containSeparator.Split(_entry.Punctuators.SEPARATOR);

			return new Entry(
				new _entry.Term(split[0])
				,
				new _entry.Term(split[1])	
			);
		}

	}
}
