using nilnul.web._url._origin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url.origin_
{
	/// <summary>
	/// aka: Svr
	/// </summary>
	public class NoCredential : OriginI2
	{
		private Scheme _scheme;

		public Scheme scheme
		{
			get { return _scheme; }
			set { _scheme = value; }
		}
		private _origin. authority_.NoCredential _authority;

		public _origin. authority_.NoCredential authority
		{
			get { return _authority; }
			set { _authority = value; }
		}

		AuthorityI2 OriginI2.authority => _authority;

		public NoCredential(Scheme scheme, _origin. authority_.NoCredential authority )
		{
			_scheme = scheme;
			_authority = authority;
		}

	}
}
