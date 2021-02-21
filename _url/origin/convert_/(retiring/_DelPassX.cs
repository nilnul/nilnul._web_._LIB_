using nilnul.web._url;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url.origin.convert_
{
	static public class _DelPassX
	{
		static public OriginI Op(nilnul.web._url.OriginI1 origin) {
			return new _url.Origin(
				origin.scheme
				,
				_url.authority.convert_._DelPassX.Op(
					origin.authority
				)
				
			);
		}
	}
}
