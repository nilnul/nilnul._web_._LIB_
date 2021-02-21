using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.url
{
	public interface EqI:
		//IEqualityComparer<nilnul.web.Url3>, 
		IEqualityComparer<nilnul.web.Url3>
	{
	}

	public interface EqI1:
		IEqualityComparer<nilnul.web.UrlI3>
	{
	}


	public abstract class EqA: nilnul.obj._eq_.HashCodeA<Url3>
		,EqI
	{
		
	}
	public class Eq : EqI,EqI1
	{
		public bool Equals(UrlI3 x, UrlI3 y)
		{
			return _url.origin.Eq.Singleton.Equals(x.origin, y.origin)
				&& 
				_url.resource.Eq.Singleton.Equals( nilnul.web.Url3.Resource(x), nilnul.web.Url3.Resource(y) )


				;
			//throw new NotImplementedException();
		}

		public bool Equals(Url3 x, Url3 y)
		{
			return Equals((UrlI3)x, (UrlI3) y);
		}


		public int GetHashCode(UrlI3 obj)
		{
			return _url.origin.Eq.Singleton.GetHashCode(obj.origin)
				&
				_url.resource.Eq.Singleton.GetHashCode(nilnul.web.Url3.Resource( obj))
			;
			//throw new NotImplementedException();
		}

		public int GetHashCode(Url3 obj)
		{
			return GetHashCode((UrlI3)obj);
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
