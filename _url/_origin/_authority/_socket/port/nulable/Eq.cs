using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.web._url_._authority_._socket_;

namespace nilnul.web._url._origin._authority._socket.port.nulable
{

	public class Eq : EqI
	{
		
		public bool Equals(_url._origin._authority._socket.Port x, _url._origin._authority._socket.Port y)
		{
			
			
			if (x==null )
			{
				if (y==null)
				{
					return true;
				}
				//else if (y==80)  //what if not http
				//{

				//}
				return false;
			}

			return port.Eq.Singleton.Equals(x, y);
			//throw new NotImplementedException();
		}

		public int GetHashCode(_url._origin._authority._socket.Port obj)
		{
			if (obj==null)
			{
				return 0;
			}
			return port.Eq.Singleton.GetHashCode(obj);
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
