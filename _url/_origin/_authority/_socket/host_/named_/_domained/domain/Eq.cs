using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.web._url._origin._authority._socket._host;
using nilnul.web._url._origin._authority._socket.host_.named_._domained;

namespace nilnul.web._url._origin._authority._socket._host.domain
{
	public interface EqI : IEqualityComparer<Domain
>
	{ }
	public class Eq :
		nilnul.obj.eq_.Homomorph<Domain, string, nilnul.txt.eq_.CaseInsensitive>
		, EqI
	{
		public Eq() : base(
			domain=>domain.ToString()
		)
		{
		}

		//public bool eq(Domain domain, string x) {
		//	return nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(domain.ToString(), x);
		//}


		static public Eq Singleton
		{
			get
			{
				return nilnul.Singleton1<Eq>.Instance;
			}
		}

	}
}
