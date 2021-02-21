using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url
{
	extern alias character;
	public class Punctuators : character::nilnul.character.Set
	{
		public const char EndScheme = ':';
		public const char AroundRadic = '/';
		public const char IntroQuery = '?';
		public const char IntroFragment = '#';

		public const char EndCredential = '@';

		public Punctuators():base(
			':'
			//,
			//'\\'
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

		)
		{

		}

		


		static public readonly Punctuators Singleton = SingletonByDefault<Punctuators>.Instance;


		
	}
}
