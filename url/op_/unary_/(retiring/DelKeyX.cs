using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.url.convert_
{
	[Obsolete()]
	static public class _DelKeyX
	{
		static public nilnul.web.Url3 Op(nilnul.web.UrlI3 url) {
			return new Url3(
				_url.origin.convert_._DelKeyX.Op
				(
					url.origin
				)
				,
				url.route
				,
				url.query
				,url.fragment
			);
		}
		static public nilnul.web.Url3 Op(nilnul.web.Url3 url) {
			return new Url3(
				_url.origin.convert_._DelKeyX.Op
				(
					url.origin
				)
				,
				url.route
				,
				url.query
				,url.fragment
			);
		}

	}
}
