using nilnul.web._url._origin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url
{
	/// <summary>
	/// without the ending slash
	/// </summary>
	public class Origin1 : _url.OriginI2
	{
		private Scheme _scheme;
		public Scheme scheme
		{
			get
			{

				return _scheme;
				//throw new NotImplementedException();
			}
		}

		private AuthorityI2 _authority;
		public AuthorityI2 authority
		{
			get
			{
				return _authority;

				//throw new NotImplementedException();
			}
		}


		public Origin1( Scheme scheme, AuthorityI2 authority)
		{
			_scheme = scheme;
			_authority = authority;
		}

		public Origin1(string fTP, Authority2 authority1):this(new Scheme(fTP),authority1)
		{
		}

		public override string ToString()
		{
			return _origin_._PhraseX.Txt(_scheme,_authority);
		}
	}
}
