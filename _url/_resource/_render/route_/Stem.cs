using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;

namespace nilnul.web._url._resource._render.route_
{
	public class Stem:nilnul.fs._address.route_.Stem
	{
		public Stem()
		{

		}

		public Stem(DivI val) : base(val)
		{
		}

		public Stem(IEnumerable<DirI> enumerable) : base(enumerable)
		{
		}

		public Stem(DivisionI x) : base(x)
		{
		}

		public override string ToString()
		{
			return base.ToString().Replace('\\','/');
		}
	}
}
