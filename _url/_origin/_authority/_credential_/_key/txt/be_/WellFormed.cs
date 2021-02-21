using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url_._authority_._credential_.key.txt.be_
{
	extern alias character;
	public class WellFormed : nilnul.txt.BeI
	{

		static public character::nilnul.character.Set excludedChars = new character::nilnul.character.Set(
			':'
			
		);

		static private nilnul.txt.be_.Exclude _exclude;

		static public nilnul.txt.be_.Exclude exclude
		{
			get { return _exclude; }
			//set { _exclude = value; }
		}
		public WellFormed()
		{
			_exclude = new nilnul.txt.be_.Exclude(excludedChars);
		}

		public bool be(string obj)
		{
			return _exclude.be(obj);

			//throw new NotImplementedException();
		}

		
	}
}
