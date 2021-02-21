using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._origin._authority._socket.host_.named_._domained._domain._brand.txt.be_
{
	extern alias character;

	public class Well : nilnul.txt.BeI
	{
		static public nilnul.character.SetI allowedChars = nilnul.character.set.accumulate_.Union1.Singleton.eval(
			nilnul.character.set_.DigitLetter.Singleton
			,
			new character::nilnul.character.Set(
				'-'
				,
				'_'
				
			)	
		);

		static public nilnul.txt.be_.FroChars froChars = new nilnul.txt.be_.FroChars(allowedChars);

		public bool be(string obj)
		{
			return obj.Length>=1 && froChars.be(obj);

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
