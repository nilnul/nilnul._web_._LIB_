using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._resource._render._route
{
	/// <summary>
	/// the end in :
	///		"a/"
	/// </summary>
	static public class _SeparatorX
	{
		public const char CHARACTER = '/';
		static public string Txt = CHARACTER.ToString();

		static public void Vow(char c) {
			nilnul.obj.vow_.True.Singleton.vow(c==CHARACTER);
		}
	}
}
