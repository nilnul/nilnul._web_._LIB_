using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._resource._render.route.nulable
{
	public class _TipX
	{
		static public string TxtNul(Route route)
		{
			if (route ==null)
			{
				return null;
			}
			return _render.route._TipX.Txt(route);//.ti route.division;
		}
		static public string Txt(Route route)
		{
			return TxtNul(route) ?? "";
		}

	}
}
