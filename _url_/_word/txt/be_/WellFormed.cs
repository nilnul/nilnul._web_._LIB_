using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._word.txt.be_
{
	extern alias character;
	public class WellFormed : nilnul.txt.BeI
	{

		static public character::nilnul.character.Set excludedChars = new character::nilnul.character.Set(
			':'
			,
			'\\'
			,
			'/'
			,
			'@'
			,
			'?'
			//,
			//'&'
			//,
			//'='
			,
			'#'
			//,
			//'+'	//for space connected str.
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


		static public readonly WellFormed Singleton = SingletonByDefault<WellFormed>.Instance;


		public class En : nilnul.txt.be.En_beSingleton<WellFormed>
		{
			public En(string s) : base(s)
			{
			}
		}
	}
}
