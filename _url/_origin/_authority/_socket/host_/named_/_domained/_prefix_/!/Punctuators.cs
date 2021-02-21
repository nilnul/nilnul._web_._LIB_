using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._host._prefix
{
	extern alias character;

	public class Punctuators:
		character::nilnul.character.Set
	{
		public const char DOT = '.';
		public Punctuators():base(DOT)
		{

		}
	}
}
