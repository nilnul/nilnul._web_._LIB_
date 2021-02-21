using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.web._url._resource;
using nilnul.web._url._resource._render;

namespace nilnul.web._url
{
	/// <summary>
	/// 
	/// </summary>
	public interface ResourceI:_resource_.RenderI, _resource_.FragI
	{
	}

	public class Resource :
		_resource_.RenderA
		,
		ResourceI
	{

		public Resource(Render render, _url.Fragment frag) : base(render)
		{
			this.frag = frag;
		}

		public Resource(Route route, Query query, Fragment fragment):this(new Render(route,query),fragment)
		{
		}

		public Fragment frag {
			get;
			set;
		}

		public override string ToString()
		{
			return $"{this.render}{_url.frag.nulable._PhraseX.Phrase(frag)}";
		}
	}
}
