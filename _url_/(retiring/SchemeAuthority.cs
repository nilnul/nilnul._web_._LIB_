using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url_
{
	[Obsolete(nameof(Origin))]
	public class SchemeAuthority
	{
		private Scheme _scheme;

		public Scheme  scheme
		{
			get { return _scheme; }
			set { _scheme = value; }
		}

		private Authority _authority;

		public Authority authority
		{
			get { return _authority; }
			set { _authority = value; }
		}

		public SchemeAuthority(
			Scheme scheme
			,
			Authority authority	
		)
		{
			_scheme = scheme;
			_authority = authority;

		}




	}
}
