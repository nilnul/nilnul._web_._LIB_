using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url.origin.eq_
{
	public class DisregardCredential : origin.EqI
	{
		public bool Equals(OriginI2 x, OriginI2 y)
		{
			return origin.Eq.Singleton.Equals(
				convert_._DelCredentialX.Op(x)
				,
				convert_._DelCredentialX.Op(y)
			);
			//throw new NotImplementedException();
		}

		public int GetHashCode(OriginI2 obj)
		{
			return origin.Eq.Singleton.GetHashCode(convert_._DelCredentialX.Op(obj));
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
