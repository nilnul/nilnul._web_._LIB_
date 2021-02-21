using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._resource._render.route.nulable
{
	static public class _CoerceX
	{
		static public Route Coerce(Route r) {
			if (r==null)
			{
				return new Route(
					new _url._resource._render._route.Div()
				);
			}
			return r;
		}
	}
	public class Coerce
	{
	}
}
