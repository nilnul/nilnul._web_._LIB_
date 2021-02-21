using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.web.url.op_.unary_
{
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
			return Op((nilnul.web.UrlI3)url);
		}

		//static public string _Op_byRegexOnTxt(string _pseudoUrl) {
		//	return Regex.Replace(_pseudoUrl,@"(?<=)","");
		//}
		static public nilnul.web.Url3 Op(string url) {
			return Op(
				nilnul.web.url._ParseX3.Parse(url)
			);
		}


	}
}