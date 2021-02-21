using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url.resource
{
	public class Eq : IEqualityComparer<ResourceI>
	{
		public bool Equals(ResourceI x, ResourceI y)
		{
			return _url._resource.render.Eq.Singleton.Equals(x.render, y.render)
				&&
				_url._resource.frag.nulable.Eq.Singleton.Equals(x.frag, y.frag);

			//throw new NotImplementedException();
		}

		public int GetHashCode(ResourceI obj)
		{
			return _url._resource.render.Eq.Singleton.GetHashCode(obj.render)
				&
				_url._resource.frag.nulable.Eq.Singleton.GetHashCode(obj.frag)
			;
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
