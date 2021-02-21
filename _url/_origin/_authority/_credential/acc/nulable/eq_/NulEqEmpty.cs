using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._origin._authority._credential.acc.nulable.eq_
{
	public class NulEqEmpty : EqI
	{
		public bool Equals(Acc x, Acc y)
		{
			if (x == null)
			{
				if (y == null)
				{
					return true;
				}
				if (y.result == "")
				{
					return true;
				}
				return false;
			}
			if (y == null)
			{
				return Equals(y, x);
			}
			return x.result == y.result;

			//throw new NotImplementedException();
		}

		public int GetHashCode(Acc obj)
		{

			if (obj == null)
			{

				return 0;
			}
			if (obj == "")
			{
				return 0;
			}
			return obj.result.GetHashCode();
		}

		static public NulEqEmpty Singleton
		{
			get
			{
				return nilnul.Singleton1<NulEqEmpty>.Instance;
			}
		}

	}

	

}
