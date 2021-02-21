using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url.origin.convert_
{
	static public class _EnsureAccX
	{
		static public OriginI2 Op(nilnul.web._url.OriginI2 origin, _url._origin._authority._credential.Acc acc) {
			return new _url.Origin1(
				origin.scheme
				,
				_url._origin.authority.convert_._EnsureAccX.Op(
					origin.authority
					,acc
				)
				
			);
		}
	}
}
