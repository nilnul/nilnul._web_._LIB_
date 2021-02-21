using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.web._url_._authority_._socket_;

namespace nilnul.web._url._origin._authority._socket.host
{
	public interface EqI1:IEqualityComparer<_url._origin._authority._socket.HostI1> { }

	public class Eq1 : EqI1
	{
		public bool Equals(HostI1 x, HostI1 y)
		{
			return nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(x.ToString(),y.ToString());
			//throw new NotImplementedException();
		}

		public int GetHashCode(HostI1 obj)
		{
			return 0;
			//throw new NotImplementedException();
		}

		static public Eq1 Singleton
		{
			get
			{
				return nilnul.Singleton1<Eq1>.Instance;
			}
		}

	}
}
