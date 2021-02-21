using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._resource.frag.nulable
{
	static public class _PhraseX
	{
		static public string Phrase(Fragment frag) {
			return (frag?.ToString() ) ?? "";
		}
	}
}
