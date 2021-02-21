using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._resource._render.query
{
	public class Eq : IEqualityComparer<_url.Query>
	{
		public bool Equals(Query x, Query y)
		{
			return x.ToString() == y.ToString();
			throw new NotImplementedException();
		}

		public int GetHashCode(Query obj)
		{
			return obj.ToString().GetHashCode();
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
