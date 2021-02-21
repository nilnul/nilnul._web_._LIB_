using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.web._url_._authority_._socket_;

namespace nilnul.web._url._origin._authority._socket.host_.named_.domained
{
	public interface EqI:IEqualityComparer<_url._origin._authority._socket.host_.named_.DomainedI> { }

	public class Eq : EqI
	{
		public bool Equals(DomainedI x, DomainedI y)
		{
			return nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(x.ToString(),y.ToString());
			//throw new NotImplementedException();
		}

		public int GetHashCode(DomainedI obj)
		{
			return 0;
			//throw new NotImplementedException();
		}

		static public Eq Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq>.Instance;
			}
		}

	}
}
