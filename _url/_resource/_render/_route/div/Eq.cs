using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._resource._render._route.div
{
	public interface EqI
		:IEqualityComparer<Div>
	{ }
	public class Eq : EqI
	{
		static public nilnul.obj.str_.enumable.Eq<Dir> dirsEq = new obj.str_.enumable.Eq<Dir>(dir.Eq.Singleton);

		public bool Equals(Div x, Div y)
		{
			return dirsEq.Equals(x.dirs.enumerable, y.dirs.enumerable);
			//throw new NotImplementedException();
		}

		public int GetHashCode(Div obj)
		{
			return 0;
			throw new NotImplementedException();
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
