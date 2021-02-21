using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._origin._authority._hostPort._host
{
	public interface SuffixI
	{
	}

	public abstract class SuffixA:SuffixI
	{

		static public SuffixA Parse(string txt) {
			var splitted = txt.Split('.');

			if (splitted.Length==1)
			{
				if (splitted[0].Length==2)
				{
					return suffix_.Country.Parse(splitted[0]);
				}
				return suffix_.Mission.Parse(splitted[0]);
			}
			if (splitted.Length==2)
			{
				if (splitted[0].Length==2)
				{
					return suffix_.AbbrCountry.Parse(
						splitted[0]
						,
						splitted[1]	
					);
				}
				return suffix_.MissionCountry.Parse(
					splitted[0]
					,
					splitted[1]	
				);

			}


			throw new FormatException();
		}

	}
}
