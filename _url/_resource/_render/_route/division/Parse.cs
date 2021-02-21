using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.web._url._resource._render._route.division
{
	/// <summary>
	/// </summary>
	public static class _ParseX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		static public DivisionI Parse(string s)
		{
			if (Regex.IsMatch(s, @"[^\/]\z"))
			{
				return div.Document.Parse(s);
			}
			return Div.Parse(s);
		}
	}
}