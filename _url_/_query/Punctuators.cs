using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._query
{
	extern alias character;
	/// <summary>
	/// punctuators used to destruct query. not recursively.
	/// 
	/// </summary>
	public class Punctuators
		:character::nilnul.character.Set
	{
		public Punctuators():base('&')
		{

		}

		static public readonly Punctuators Singleton = SingletonByDefault<Punctuators>.Instance;

	}
}
