using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.web._url_._authority_;

namespace nilnul.web._url._origin._authority.credential
{
	public interface EqI : IEqualityComparer<_url._origin._authority.Credential1> {

	}
	public class Eq : EqI
	{
		public bool Equals(_url._origin._authority.Credential1 x, _url._origin._authority.Credential1 y)
		{
			return _credential.acc.nulable.eq_.NulEqEmpty.Singleton.Equals(x.username, y.username)
				&&
				_credential.key.nulable.eq_.NulEqEmpty.Singleton.Equals(x.password,y.password)
			;
			//throw new NotImplementedException();
		}

		public int GetHashCode(_url._origin._authority.Credential1 obj)
		{
			return _credential.acc.nulable.eq_.NulEqEmpty.Singleton.GetHashCode(obj.username)
				&

				_credential.key.nulable.eq_.NulEqEmpty.Singleton.GetHashCode(obj.password)
			;
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
