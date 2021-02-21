using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.web._url_._authority_;

namespace nilnul.web._url._origin._authority.credential.nulable
{
	public interface EqI : IEqualityComparer<_url._origin._authority.Credential1> {

	}
	public class Eq : EqI
	{
		public bool Equals(_url._origin._authority.Credential1 x, _url._origin._authority.Credential1 y)
		{
			if (x==null)
			{
				return y == null;
			}
			if (y==null)
			{
				return Equals(y, x);
			}
			return credential.Eq.Singleton.Equals(x, y);
			;
			//throw new NotImplementedException();
		}

		public int GetHashCode(_url._origin._authority.Credential1 obj)
		{
			if (obj==null)
			{
				return 0;
			}
			if (obj.isBothNull())
			{
				return 0;
			}
			return credential.Eq.Singleton.GetHashCode(obj);
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
