using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._resource.frag
{
	public class Eq : IEqualityComparer<_url.Fragment>
	{
		public bool Equals(_url.Fragment x, _url.Fragment y)
		{
			return x.en == y.en;
			//throw new NotImplementedException();
		}

		public int GetHashCode(_url.Fragment obj)
		{
			return obj.en.GetHashCode();
			//throw new NotImplementedException();
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
