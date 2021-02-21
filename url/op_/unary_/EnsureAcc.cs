using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.url.convert_
{
	static public class _EnsureAccX
	{
		static public nilnul.web.Url3 Op(nilnul.web.UrlI3 url, _url._origin._authority._credential.Acc acc) {
			return new Url3(
				_url.origin.convert_._EnsureAccX.Op
				(
					url.origin
					,acc
				)
				,
				url.route
				,
				url.query
				,url.fragment
			);
		}
		static public nilnul.web.Url3 Op(nilnul.web.Url3 url, _url._origin._authority._credential.Acc acc) {
			return Op(
				(nilnul.web.UrlI3) url
				,
				acc
			);
		}

	}
}
