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
	/// 
	[Obsolete()]
	public class Origin : _url.OriginI1
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

		private Authority1 _authority;
		public Authority1 authority
		{
			get
			{
				return _authority;

				//throw new NotImplementedException();
			}
		}


		public Origin( Scheme scheme, Authority1 authority)
		{
			_scheme = scheme;
			_authority = authority;
		}

		public override string ToString()
		{
			return $"{scheme}://{authority}";
		}
	}
}
