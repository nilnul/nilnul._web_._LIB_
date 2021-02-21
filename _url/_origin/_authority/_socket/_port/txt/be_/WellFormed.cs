using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._port.txt.be_
{
	extern alias character;
	/// <summary>
	/// 16bit uint  [0,65536)
	/// </summary>
	public class WellFormed : nilnul.txt.BeI
	{

		
		public WellFormed()
		{
		}

		public bool be(string obj)
		{

			return obj.Length<=5 && nilnul.txt.be_.Digit.Singleton.be(obj);

			//throw new NotImplementedException();
		}

		public class En : nilnul.txt.be.En_beSingleton<WellFormed>
		{
			public En(string s) : base(s)
			{
			}
		}
	}
}
