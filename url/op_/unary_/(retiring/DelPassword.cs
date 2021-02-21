using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.url.convert_
{
	[Obsolete()]
	static public class _DelPassX
	{
		static public nilnul.web.Url2 Op(nilnul.web.Url2 url) {
			return new Url2(
				_url.origin.convert_._DelPassX.Op
				(
					url.origin
				)
				,
				url.route,
				url.query,
				url.fragment
			);
		}
	}
}
