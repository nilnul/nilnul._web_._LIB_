using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._origin._authority._socket
{
	/// <summary>
	/// [0,2^16), among which [0,1024) are reserved. 
	/// </summary>
	public class Port : nilnul.num_.ranged_.lt_.BinPow16
	{

		public Port(int port1):this((nilnul.Num) port1)
		{
		}

		public Port(nilnul.Num num) : base(num )
		{
		}

		static public Port Create(int i) {
			return new Port(
				(nilnul.Num)i
			);
		}



		static public Port Parse(string s) {
			return new Port(
				( nilnul.Num)
				int.Parse(s)
			);
		}
	}
}
