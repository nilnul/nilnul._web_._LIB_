using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.url.nulable.str.combine_.except_
{
	namespace _delKey
	{
		public class Eq : IEqualityComparer<string>
		{
			public bool Equals(string x, string y)
			{
				if (x==y)
				{
					return true;
				}
				var xParsed = nilnul.web.url.nulable._ParseX.Parse(x);
				if (xParsed==null )
				{
					return false;
				}

				var yParsed = nilnul.web.url.nulable._ParseX.Parse(y);
				if ( yParsed ==null)
				{
					return false;
				}
				return nilnul.web.url.eq_.DelKey.Singleton.Equals(xParsed, yParsed);
				//throw new NotImplementedException();
			}

			public int GetHashCode(string obj)
			{
				return 0;
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

	static public class _DelKeyX
	{
		static public IEnumerable<string> Txts(IEnumerable<string> x, IEnumerable<string> y)
		{
			return x.Except(y, _delKey.Eq.Singleton);
		}
	}
}
