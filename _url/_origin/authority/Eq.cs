using nilnul.web._url._origin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._origin.authority
{
	public interface EqI : IEqualityComparer<AuthorityI2> { }
	public class Eq : EqI
	{
		public bool Equals(AuthorityI2 x, AuthorityI2 y)
		{
			return _origin. _authority.credential.nulable.Eq.Singleton.Equals(
				x.credential
				,
				y.credential
			)
			&&
			_origin. _authority.socket.Eq.Singleton.Equals(
				x.socket
				,y.socket
			);
			//throw new NotImplementedException();
		}

		public int GetHashCode(AuthorityI2 obj)
		{
			return 0;
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
