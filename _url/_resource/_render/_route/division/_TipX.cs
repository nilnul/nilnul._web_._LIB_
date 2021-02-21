using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._resource._render._route.division
{
	static public class _TipX
	{
		static public string Tip( DivisionI division) {
			switch (division)
			{
				case _route.Div div:
					return _route.div._TipX.Tip(div);
				case _route.div.Document document:
					return _route.div.document._TipX.Txt(document);
				default:
					throw new UnexpectedTypeException();
					break;
			}
		}
	}
}
