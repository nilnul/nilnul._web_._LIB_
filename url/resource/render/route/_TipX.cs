using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.url.resource.render.route
{
	public class _TipX
	{
		public static string TxtNul(UrlI3 url)
		{
			return nilnul.web._url._resource._render.route.nulable._TipX.TxtNul(
				url.route
			);
		}
		public static string Txt(UrlI3 url)
		{
			return TxtNul(url)??"";
		}

		public static string TxtNul(string url)
		{
			return TxtNul(nilnul.web.url._ParseX3.Parse(url));
		}
		public static string Txt(string url)
		{
			return TxtNul(url)??"";
		}

	}
}
