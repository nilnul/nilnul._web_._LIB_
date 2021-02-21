using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._resource._render.query.nulable
{
	public class Eq : IEqualityComparer<_url.Query>
	{
		public bool Equals(Query x, Query y)
		{
			if (x==null)
			{
				return y == null;
			}
			if (y==null)
			{
				return Equals(y, x);
			}
			return query.Eq.Singleton.Equals(x, y);
			//throw new NotImplementedException();
		}

		public int GetHashCode(Query obj)
		{
			return obj==null?0:obj.GetHashCode();
			//throw new NotImplementedException();
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
