using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._origin._authority
{
	extern alias character;

	public class Punctuators
		:character::nilnul.character.Set
	{
		public const char Splitter = '@';

		public Punctuators():base(Splitter)
		{

		}


		static public readonly Punctuators Singleton = SingletonByDefault<Punctuators>.Instance;



	}
}
