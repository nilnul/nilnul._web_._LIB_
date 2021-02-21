using nilnul.web._url._origin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._origin_
{
	public class _PhraseX
	{
		static public string _Txt(string scheme, string authority) {
			return $"{scheme}://{authority}";

		}

		public static string Txt(Scheme scheme, AuthorityI2 authority)
		{
			return _Txt(scheme.ToString(),authority.ToString());
		}
	}
}
