using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.url.eq_
{
	

	public class ByOriginAndRoute : EqI
	{
		public bool Equals(Url3 x, Url3 y)
		{
			return _url.origin.Eq.Singleton.Equals(x.origin, y.origin)
				&&
				_url._resource._render.route.nulable.Eq.Singleton.Equals(x.route, y.route)

				;
			//throw new NotImplementedException();
		}

		public int GetHashCode(Url3 obj)
		{
			return 0;
			throw new NotImplementedException();
		}

		static public ByOriginAndRoute Singleton
		{
			get
			{
				return nilnul.Singleton1<ByOriginAndRoute>.Instance;
			}
		}

	}
}
