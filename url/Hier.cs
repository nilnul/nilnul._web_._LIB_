using nilnul.web._url;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.url
{
	/// <summary>
	/// this can be any char. scheme less
	/// </summary>
	public class _Hierarchy
	{
		private _url._origin.Authority2 _authority;

		public _url._origin.Authority authority
		{
			get { return _authority; }
			set { _authority = value; }
		}
		private Sprig _sprig;

		public Sprig sprig
		{
			get { return _sprig; }
			set { _sprig = value; }
		}

		public _Hierarchy()
		{

		}

	}


	
}
