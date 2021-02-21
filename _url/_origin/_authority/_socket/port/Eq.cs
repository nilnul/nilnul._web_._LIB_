using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.web._url_._authority_._socket_;

namespace nilnul.web._url._origin._authority._socket.port
{
	public interface EqI:IEqualityComparer<_url._origin._authority._socket.Port> { }

	public class Eq : EqI
	{
		
		public bool Equals(_url._origin._authority._socket.Port x, _url._origin._authority._socket.Port y)
		{
			return nilnul.num.Eq.Singleton.Equals(x.ed, y.ed);
			//throw new NotImplementedException();
		}

		public int GetHashCode(_url._origin._authority._socket.Port obj)
		{
			return nilnul.num.Eq.Singleton.GetHashCode(obj);
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
