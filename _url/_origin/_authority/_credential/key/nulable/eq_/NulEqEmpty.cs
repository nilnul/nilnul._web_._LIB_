using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._origin._authority._credential.key.nulable.eq_
{
	public class NulEqEmpty : EqI
	{
		public bool Equals(_url._origin._authority._credential.Key x, _url._origin._authority._credential.Key y)
		{
			if (x == null)
			{
				if (y == null)
				{
					return true;
				}
				if (y.ed == "")
				{
					return true;
				}
				return false;
			}
			if (y == null)
			{
				return Equals(y, x);
			}
			return x.ed == y.ed;

			//throw new NotImplementedException();
		}

		public int GetHashCode(_url._origin._authority._credential.Key obj)
		{

			if (obj == null)
			{

				return 0;
			}
			if (obj == "")
			{
				return 0;
			}
			return obj.ed.GetHashCode();
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
