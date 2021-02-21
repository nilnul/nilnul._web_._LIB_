using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._word.txt.be_.well
{
	public class NonBlank
		: nilnul.txt.BeI
	{
		public bool be(string obj)
		{
			return WellFormed.Singleton.be(obj) && nilnul.txt.be_.NonBlank.Singleton.be(obj);

			//throw new NotImplementedException();
		}

		static public readonly NonBlank Singleton = SingletonByDefault<NonBlank>.Instance;

		public class En : nilnul.txt.be.En_beSingleton<NonBlank>
		{
			public En(string s) : base(s)
			{
			}
		}
	}
}
