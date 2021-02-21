using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._resource._render._route.dir
{
	public class Eq : IEqualityComparer<Dir>
	{
		public bool Equals(Dir x, Dir y)
		{
			return x.name.ToString() == y.name.ToString();
			//throw new NotImplementedException();
		}

		public int GetHashCode(Dir obj)
		{
			return 0;
			throw new NotImplementedException();
		}

		static public Eq Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq>.Instance;
			}
		}

	}
}
