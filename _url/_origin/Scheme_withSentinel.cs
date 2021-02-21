using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._origin
{
	/// <summary>
	/// the part before and at the first "://". note "://" is included. known as protocol in js.
	/// </summary>
	/// 
	public class Scheme1 :
		_url._scheme.txt.be_.WellFormed.En

	{
		public const string SENTINEL = "://";

		public Scheme1(string s) : base(s)
		{
		}

		public override string ToString()
		{
			return $"{this}{SENTINEL}";
		}

		static public Scheme1 Ftp = new Scheme1("ftp");

	}
}
