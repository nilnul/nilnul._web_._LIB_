using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._mission.txt.be_
{
	public class Well
		: nilnul.txt.BeI
	{
		static public nilnul.txt.SetI names = new nilnul.txt.set_.BothCasesOnStr(
			"org","net","com"
			,"gov","mil","edu"
			
			,"info"
			,
			"name"
			,
			"mobi"
			
		);

		
		public bool be(string obj)
		{
			return names.contains(obj);

		//	throw new NotImplementedException();
		}
	}
}
