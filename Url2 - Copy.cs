using nilnul.web._url;
using nilnul.web._url._origin;
using nilnul.web._url._resource._render;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web
{
	/// <summary>
	/// 
	/// </summary>
	public class Url3 :_url_.ResourceI, UrlI3
	{
		private OriginI2 _origin;
		public OriginI2 origin
		{
			get { return _origin; }
			set { _origin = value; }
		}

		private _url._resource._render.Route _route;
		public _url._resource._render.Route route
		{
			get { return _route; }
			set { _route = value; }
		}

		private _url.Query _query;
		public _url.Query query
		{
			get { return _query; }
			set { _query = value; }
		}

		private _url.Fragment _fragment;
		public _url.Fragment fragment
		{
			get { return _fragment; }
			set { _fragment = value; }
		}

		public ResourceI resource =>new _url.Resource(this.route,this.query,this.fragment);
		static public ResourceI Resource(UrlI3 url) =>new _url.Resource(url.route,url.query,url.fragment);


		public Url3(OriginI2 origin, _url._resource._render.Route route = null, Query query = null, Fragment frag = null)
		{
			_origin = origin;
			_route = route;
			_query = query;
			_fragment = frag;
		}

		public Url3(Scheme scheme, Authority2 authority, Route route, Query query, Fragment frag)
			:this(
				 new Origin1(scheme,authority)
				,route,
				 query,
				 frag 
			 )
		{
		}

		public Url3(UrlI3 url):this(url.origin,url.route,url.query,url.fragment)
		{

		}

		//public Url3(OriginI2 origin, Route route = null, Query query = null, Fragment frag = null) : this(origin, route, query, frag)
		//{
		//}

		public Url3(OriginI2 originI2, ResourceI resource1):this(
			originI2,
			resource1.render.route,
			resource1.render.query,
			resource1.frag
		)
		{
		}


		/// <summary>
		/// note for "http://abc.com", an origin, has to be normalzied as "http://abc.com/", a url
		/// </summary>
		/// <returns></returns>

		public override string ToString()
		{

			var sb = new StringBuilder();
			sb.Append(origin);

			if (_route!=null)
			{
				sb.Append($"{_route}");

			}
			if (_query!=null)
			{
			sb.Append(_url.Punctuators.IntroQuery.ToString() +_query.ToString());

			}
			if (_fragment!=null)
			{
				sb.Append(
					_url.Punctuators.IntroFragment.ToString() +_fragment
				);

			}
			


			return sb.ToString();
		}

		static public string CreateUrlTxtWithNoEndSlash(string scheme, string authority)
		{
			return $"{scheme}://{authority}";

		}

		static public Url3 CreateFroSchemeAuthority(string scheme, string authority)
		{
			return CreateFroSchemeAuthority(new Scheme(scheme), Authority2.Parse(authority));

		}

		static public Url3 CreateFroSchemeAuthority(Scheme scheme, Authority2 authority)
		{
			return CreateFroOrigin(new Origin1(scheme, authority));

		}


		static public Url3 CreateFroOrigin(_url.Origin1 origin)
		{
			return new Url3(origin);

		}
	}
}