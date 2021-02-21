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
	public class Url4 : UrlI4, UrlI3
	{
		private OriginI2 _origin;
		public OriginI2 origin
		{
			get { return _origin; }
			set { _origin = value; }
		}

		private _url.ResourceI _resource;
		public _url.ResourceI resource
		{
			get { return _resource; }
			set { _resource = value; }
		}

		public Route route => _resource.render.route;

		public Query query { get => _resource.render.query; set => _resource.render.query = value; }
		public Fragment fragment {
			get => _resource.frag;
			set => throw new Exception();// _resource.frag=value;
		}

		public Url4(OriginI2 origin, _url.Resource route = null)
		{
			_origin = origin;
			_resource = route;
			
		}

		public Url4(Scheme scheme, Authority2 authority, Route route, Query query, Fragment frag)
			:this(
				 new Origin1(scheme,authority)
				,new Resource(route,query,frag)
			 )
		{
		}
		public Url4(OriginI2 authority, Route route, Query query, Fragment frag)
			:this(
				authority
				,new Resource(route,query,frag)
			 )
		{
		}

		public Url4(UrlI3 url):this(url.origin,url.route,url.query,url.fragment)
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

			if (_resource!=null)
			{
				sb.Append($"{_resource}");

			}
			
			


			return sb.ToString();
		}

		static public string CreateUrlTxtWithNoEndSlash(string scheme, string authority)
		{
			return $"{scheme}://{authority}";

		}

		static public Url4 CreateFroSchemeAuthority(string scheme, string authority)
		{
			return CreateFroSchemeAuthority(new Scheme(scheme), Authority2.Parse(authority));

		}

		static public Url4 CreateFroSchemeAuthority(Scheme scheme, Authority2 authority)
		{
			return CreateFroOrigin(new Origin1(scheme, authority));

		}


		static public Url4 CreateFroOrigin(_url.Origin1 origin)
		{
			return new Url4(origin);

		}
	}
}