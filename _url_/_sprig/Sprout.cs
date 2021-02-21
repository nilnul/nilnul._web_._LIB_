using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._sprig
{
	public class Sprout:nilnul.Opt<Dst>
	{

		public bool beEmpty {
			get {
				return this.val is nilnul._opt.NoneI;
			}
		}

		public bool beFilled {
			get {
				return this.val is nilnul._opt.OneI;
			}
		}
		public Sprout()
		{

		}
		public Sprout(Dst dst):base(dst)
		{

		}

		static public Sprout Parse(string s) {
			if (s=="")
			{
				return new Sprout();
			}
			return new Sprout(
				Dst.Parse(s)	
			);
		}
	}
}
