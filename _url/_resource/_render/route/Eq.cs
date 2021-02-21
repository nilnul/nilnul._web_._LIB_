using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._resource._render.route
{
	public class Eq : IEqualityComparer<Route>
	{
		public bool Equals(Route x, Route y)
		{
			return _route.division.Eq.Singleton.Equals(x.division,y.division);
			throw new NotImplementedException();
		}

		public int GetHashCode(Route obj)
		{
			return 0;
			throw new NotImplementedException();
		}

		static public Eq Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq>.Instance;
			}
		}

	}
}
