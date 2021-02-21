using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._origin._authority._socket.host
{
	static public class _BrandX
	{
		public static nilnul.web._url._origin._authority._socket.host_.named_._domained._domain.Brand Brand(HostI1 host)
		{
			switch (host)
			{
				case nilnul.web._url._origin._authority._socket.host_.NamedI named:
					switch (named)
					{
						case nilnul.web._url._origin._authority._socket.host_.named_.DomainedI domained:
							return domained.domain.brand;
							break;
						default:
							throw new UnexpectedTypeException($"{host} is of type {typeof(nilnul.web._url._origin._authority._socket.host_.NamedI)} but not {typeof(nilnul.web._url._origin._authority._socket.host_.named_.DomainedI)}, such that no Brand can be retrieved.");
							break;
					}
					break;
				default:
					throw new UnexpectedTypeException($"{host} is not of type {typeof(nilnul.web._url._origin._authority._socket.host_.NamedI)} (may be of type IP?), so no Brand can be retrieved.");
					break;
			}
		}

		public static nilnul.web._url._origin._authority._socket.host_.named_._domained._domain.Brand Brand(string host)
		{
			return Brand(nilnul.web._url._origin._authority._socket.HostA.Parse(host));
		}

	}
}
