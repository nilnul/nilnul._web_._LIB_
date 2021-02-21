using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._resource._render._route.division
{
	public interface EqI:IEqualityComparer<DivisionI> {
	}
	public class Eq : EqI
	{
		public bool Equals(DivisionI x, DivisionI y)
		{
			switch (x)
			{
				case Div div:
					switch (y)
					{
						case Div div1:
							return _url._resource._render._route.div.Eq.Singleton.Equals(div, div1);
							break;
						case _url._resource._render._route.div.Document document:
							return false;

							break;
						default:
							throw new UnexpectedTypeException();
							break;
					}
					break;
				case div.Document document:
					switch (y)
					{
						case div.Document document1:
							return _url._resource._render._route.div.document.Eq.Singleton.Equals(document, document1);
							break;
						case Div div:
							return false;

							break;
						default:
							throw new UnexpectedTypeException();
							break;
					}
					break;
				default:
					throw new UnexpectedTypeException();
					break;
			}
			throw new NotImplementedException();
		}

		public int GetHashCode(DivisionI obj)
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
