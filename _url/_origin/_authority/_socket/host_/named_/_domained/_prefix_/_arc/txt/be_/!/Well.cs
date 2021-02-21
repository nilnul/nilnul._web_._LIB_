using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._origin._authority._hostPort._host._prefix._arc.txt.be_
{
	extern alias character;

	public class Well : nilnul.txt.BeI
	{
		static public character:: nilnul.character.Set excludingChars = nilnul.character.set.accumulate_.Union.Singleton.eval(
			_url.Punctuators.Singleton
			,
			_url._origin._authority.Punctuators.Singleton
			,
			
			nilnul.character.set_.white_.HeritSet.Singleton
		);
		static public nilnul.txt.be_.Exclude exclude = new nilnul.txt.be_.Exclude(excludingChars);

		public bool be(string obj)
		{
			return exclude.be(obj) && obj.Length>0;

			//throw new NotImplementedException();
		}


		static public readonly Well Singleton = SingletonByDefault<Well>.Instance;

		public class En : nilnul.txt.be.En_beSingleton<Well>
		{
			public En(string s) : base(s)
			{
			}
		}

	}
}
