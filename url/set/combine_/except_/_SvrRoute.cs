using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.url.set.combine_.except_
{
	/// <summary>
	/// disregard credential, query, frag
	/// </summary>
	static public class _SvrRouteX
	{
		static public IEnumerable<Url3> Op(IEnumerable<Url3> a, IEnumerable<Url3> b) {
			return a.Except(b, url.eq_.origin9route_.DisregardCredential.Singleton);
		}

		
	}
}
