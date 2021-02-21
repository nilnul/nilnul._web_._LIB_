using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.txt.convert_.escape_.by_.dollar_.of_
{
	/// <summary>
	/// escape chars that cannot be used in Js Var.
	/// </summary>
	static public class _NonJsIdentifierX
	{

		static public string ConvertDot(
			string txt
		) {
			return txt.Replace('$'.ToString(), "$$").Replace('.'.ToString(), "$d");
		}
	}
}
