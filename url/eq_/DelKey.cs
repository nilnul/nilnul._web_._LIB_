using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.url.eq_
{
	public class DelKey : EqI
	{
		public bool Equals(Url3 x, Url3 y)
		{
			return url.Eq.Singleton.Equals(
				url.op_.unary_._DelKeyX.Op(x)
				,
				url.op_.unary_._DelKeyX.Op(y)
			);
			//throw new NotImplementedException();
		}

		public int GetHashCode(Url3 obj)
		{
			return url.Eq.Singleton.GetHashCode(
				obj
				
			);
			//throw new NotImplementedException();
		}

		static public DelKey Singleton
		{
			get
			{
				return nilnul.Singleton1<DelKey>.Instance;
			}
		}

	}
}
