using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url.scheme
{
	public interface EqI:IEqualityComparer<Scheme> { }
	public class Eq : EqI
	{
		public bool Equals(Scheme x, Scheme y)
		{
			return nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(x.avowed, y.avowed); 
			//throw new NotImplementedException();
		}

		public int GetHashCode(Scheme obj)
		{
			return nilnul.txt.eq_.CaseInsensitive.Singleton.GetHashCode(obj.avowed);
			//throw new NotImplementedException();
		}

		static public Eq Singleton
		{
			get
			{
				return nilnul.Singleton1<Eq>.Instance;
			}
		}

	}
}
