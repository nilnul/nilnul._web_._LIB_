using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url
{
	/// <summary>
	/// the query string
	/// </summary>
	public class Query
	{
		private IEnumerable<_query.Entry> _entries;

		public IEnumerable<_query.Entry> entries
		{
			get { return _entries; }
			set { _entries = value; }
		}

		public Query(IEnumerable<_query.Entry> entries)
		{
			_entries = entries;
		}
		public override string ToString()
		{
			var r = string.Join("&", _entries);
			return  string.IsNullOrEmpty(r)?"":"?"+r;
		}

		static public Query Parse(string txt) {

			var splitted = txt.Split('&');

			return new Query(
				splitted.Select( t=> _query.Entry.Parse(t))	
			);
		}

	}
}
