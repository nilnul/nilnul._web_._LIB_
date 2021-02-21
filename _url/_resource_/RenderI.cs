using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._resource_
{
	/// <summary>
	/// 
	/// </summary>
	public interface RenderI
	{
		_resource.Render render { get; }

	}

	public abstract class RenderA:RenderI
	{
		private _resource.Render _render;

		public _resource.Render render
		{
			get { return _render; }
			set { _render = value; }
		}

		public RenderA(_resource.Render render)
		{
			_render = render;
		}


	}
}
