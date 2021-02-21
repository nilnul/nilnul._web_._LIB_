using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._resource._render.route.nulable
{
	public interface EqI : IEqualityComparer<nilnul.web._url._resource._render.Route> { }
	public class Eq : EqI
	{
		public bool Equals(Route x, Route y)
		{
			return route.Eq.Singleton.Equals( nulable._CoerceX.Coerce(x), nulable._CoerceX.Coerce(y) );
			//if (x ==null)
			//{
			//	if (y==null)
			//	{
			//		return true;
			//	}
			//	else
			//	{
			//		return false;
			//	}
			//}
			//else
			//{
			//	if (y==null)
			//	{
			//		return false;
			//	}
			//	else
			//	{
			//		return route.Eq.Singleton.Equals(x,y);
			//	}
			//}
			//throw new NotImplementedException();
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
				return nilnul.Singleton1<Eq>.Instance;
			}
		}

	}
}
