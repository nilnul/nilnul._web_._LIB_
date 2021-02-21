using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._resource._render._route.div.document
{
	public class Eq : IEqualityComparer<Document>
	{
		public bool Equals(Document x, Document y)
		{
			return _url._resource._render._route.div.Eq.Singleton.Equals(x.div, y.div) 
				&&
				x.doc.ToString() == y.doc.ToString()
			;
			throw new NotImplementedException();
		}

		public int GetHashCode(Document obj)
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
