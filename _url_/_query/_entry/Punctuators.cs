using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._query._entry
{
	extern alias character;
	public class Punctuators:character::nilnul.character.Set
	{
		public const char SEPARATOR = '=';

		public Punctuators():base(SEPARATOR)
		{

		}

		static public readonly Punctuators Singleton = SingletonByDefault<Punctuators>.Instance;

	}
}
