using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._resource.render
{
	public class Eq : IEqualityComparer<RenderI>
	{
		public bool Equals(RenderI x, RenderI y)
		{
			return _url._resource._render.route.nulable.Eq.Singleton.Equals(x.route, y.route)
				&&
				_url._resource._render.query.nulable.Eq.Singleton.Equals(x.query,y.query)
			;

			throw new NotImplementedException();
		}

		public int GetHashCode(RenderI obj)
		{
			return 0;
			throw new NotImplementedException();
		}

		static public Eq Singleton
		{
			get
			{
				return nilnul.Singleton1<Eq>.Instance;
			}
		}

	}
}
