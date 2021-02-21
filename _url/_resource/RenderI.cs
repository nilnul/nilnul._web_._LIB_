using nilnul.web._url._resource._render;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._resource
{
	/// <summary>
	/// rendered by the server (whileas frag is decided by the client).
	/// route and query;
	/// </summary>
	public interface RenderI
	{
		Route route { get; }
		_url.Query query { get; }
	}
	public class Render:RenderI
	{
		/// <summary>
		/// nulable
		/// </summary>
		private Route _route;

		public Route route
		{
			get { return _route; }
			set { _route = value; }
		}

		private _url.Query _query;

		public Render(Route route, Query query)
		{
			this._route = route;
			this._query = query;
		}

		public _url.Query query
		{
			get { return _query; }
			set { _query = value; }
		}


		public override string ToString()
		{
			return $"{_url._resource._render.route.nulable._PhraseX.Phrase(_route)}{_url._resource._render.query.nulable._PhraseX.Phrase(_query)}";
		}


	}
}
