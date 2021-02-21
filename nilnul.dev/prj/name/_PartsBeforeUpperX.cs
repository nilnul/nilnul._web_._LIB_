using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj.name
{
	static public class _PartsBeforeUpperX 
	{
		static public IEnumerable<string> TxtSeq(string x) {
			return x.Split('.').TakeWhile(
				s=>s.All( c=> ! char.IsUpper(c)
				)
			);
		}
		
	}
}
