using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._query._entry._term.txt.be_
{
	extern alias character;
	public class Well : nilnul.txt.BeI
	{

		static public character::nilnul.character.Set punctuators = nilnul.character.set.accumulate_.Union.Singleton.eval(
			_url.Punctuators.Singleton,
			_query.Punctuators.Singleton
			,
			_entry.Punctuators.Singleton
		);

		static public nilnul.txt.be_.Exclude exclude = new nilnul.txt.be_.Exclude(punctuators);

		public bool be(string obj)
		{
			return exclude.be(obj);

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
