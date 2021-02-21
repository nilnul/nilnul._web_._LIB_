using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.url.eq_.origin9route_
{
	public class DisregardCredential : EqI
	{
		public bool Equals(Url3 x, Url3 y)
		{
			return eq_.ByOriginAndRoute.Singleton.Equals(
				url.convert_._DelCredentialX.Op(x)
				,
				url.convert_._DelCredentialX.Op(y)
			);
			//throw new NotImplementedException();
		}

		public int GetHashCode(Url3 obj)
		{
			return eq_.ByOriginAndRoute.Singleton.GetHashCode(
				obj
				
			);
			throw new NotImplementedException();
		}

		static public DisregardCredential Singleton
		{
			get
			{
				return nilnul.Singleton1<DisregardCredential>.Instance;
			}
		}

	}
}
