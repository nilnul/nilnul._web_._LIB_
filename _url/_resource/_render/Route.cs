using nilnul.fs._address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._resource._render
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks> 
	/// </remarks>
	public class Route 
	{
		private _route.DivisionI _division;

		public _route.DivisionI division
		{
			get { return _division; }
			//set { _division = value; }
		}

		public Route(_route.DivisionI division)
		{
			_division = division;
		}

		static public Route Parse(string s)
		{
			_route._SeparatorX.Vow(s.First());
			return new Route(
				 nilnul.web._url._resource._render._route.division._ParseX.Parse(s.Substring(1))
			);
		}

		public override string ToString()
		{
			return $"{_route._SeparatorX.Txt}{_division}";
		}



	}
}
