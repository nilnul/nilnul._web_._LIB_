using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url.origin
{
	public interface EqI : IEqualityComparer<OriginI2> { }
	public class Eq : EqI
	{
		public bool Equals(OriginI2 x, OriginI2 y)
		{
			return scheme.Eq.Singleton.Equals(
				x.scheme
				, 
				y.scheme
			)
				&&
				_origin.authority.Eq.Singleton.Equals( 
					x.authority
					,
					y.authority
				)
			;
			throw new NotImplementedException();
		}

		public int GetHashCode(OriginI2 obj)
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
