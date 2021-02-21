using nilnul.web._url;
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
	/// 
	[Obsolete()]
	public class Url2 :UrlI2
	{
		private OriginI1 _origin;
		public OriginI1 origin
		{
			get { return _origin; }
			set { _origin = value; }
		}

		private _url.Route _route;
		public _url.Route route
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


		public Url2(OriginI1 origin, Route route = null, Query query = null, Fragment frag = null)
		{
			_origin = origin;
			_route = route;
			_query = query;
			_fragment = frag;
		}

		public Url2(Scheme scheme, Authority1 authority, Route route, Query query, Fragment frag)
			:this(
				 new Origin(scheme,authority)
				,route,
				 query,
				 frag 
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

		static public Url2 CreateFroSchemeAuthority(string scheme, string authority)
		{
			return CreateFroSchemeAuthority(new Scheme(scheme), Authority1.Parse(authority));

		}

		static public Url2 CreateFroSchemeAuthority(Scheme scheme, Authority1 authority)
		{
			return CreateFroOrigin(new Origin(scheme, authority));

		}


		static public Url2 CreateFroOrigin(_url.Origin origin)
		{
			return new Url2(origin);

		}
	}
}