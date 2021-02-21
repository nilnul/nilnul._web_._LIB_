using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._resource._render.route.nulable
{
	public class _PhraseX
	{
		static public string Phrase(Route route) {
			return route?.ToString() ?? "";
		}
	}
}
