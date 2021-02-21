using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._origin._authority.socket
{
	public interface EqI : IEqualityComparer<nilnul.web._url._origin._authority.Socket> { }

	public class Eq : EqI
	{
		public bool Equals(Socket x, Socket y)
		{
			return _socket.host.Eq1.Singleton.Equals(x.host, y.host)
				&&

				_socket.port.nulable.Eq.Singleton.Equals(x.port,y.port)

			;

			//throw new NotImplementedException();
		}

		public int GetHashCode(Socket obj)
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
