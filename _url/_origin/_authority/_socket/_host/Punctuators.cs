using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._origin._authority._hostPort._host
{
	extern alias character;

	public class Punctuators:
		character::nilnul.character.Set
	{
		public const char DOT = '.';
		public Punctuators():base(DOT)
		{

		}

		static public readonly Punctuators Singleton = SingletonByDefault<Punctuators>.Instance;

	}
}
