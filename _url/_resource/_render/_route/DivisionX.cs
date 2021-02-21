using nilnul.fs._address;
using nilnul.fs._address._dst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.web._url._resource._render._route
{

	/// <summary>

	/// </summary>
	public static class DivisionX
	{

		/// <summary>
		/// the last dst after "/", if any, is taken as dir's dst
		/// </summary>
		/// <param name="division"></param>
		/// <returns></returns>
		static public Div ToDiv(DivisionI division)
		{
			if (division is Div)
			{
				return division as Div;
			}
			if (division is div.Document)   //documentI
			{
				var divisionAsDocument = division as div.Document;
				return new Div(
					dirs.Co.Singleton.co(
						divisionAsDocument.div.dirs
						,
						new Dir(
							new Denote(divisionAsDocument.doc.ToString())
						)
					)


				);

			}

			throw new UnexpectedTypeException();
		}



	}


}
