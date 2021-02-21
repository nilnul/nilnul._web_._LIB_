using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url_
{
	/// <summary>
	/// without the ending slash
	/// </summary>
	/// 
	[Obsolete(nameof(nilnul.web._url.Origin1))]
	public class Origin : _url_.OriginI
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

		private Authority _authority;
		public Authority authority
		{
			get
			{
				return _authority;

				//throw new NotImplementedException();
			}
		}


		public Origin(Authority authority, Scheme scheme)
		{
			_authority = authority;
			_scheme = scheme;
		}

		public override string ToString()
		{
			return $"{scheme}://{authority}";
		}
	}
}
