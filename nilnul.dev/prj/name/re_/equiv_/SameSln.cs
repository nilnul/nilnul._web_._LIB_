using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj.name.re_.equiv_
{
	public class SameSln : nilnul.obj.ReI<string>
	{
		
		public bool re(string a, string b)
		{
			return
				a==b
				||
				new nilnul.obj.str_.seq.Eq<string>(nilnul.txt.Eq.Singleton).Equals(
				prj.name._PartsBeforeUpperX.TxtSeq(a)
				,
				prj.name._PartsBeforeUpperX.TxtSeq(b)
			);
		}

		static public SameSln Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<SameSln>.Instance;
			}
		}

	}
}
