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
	[Obsolete()]
	public class Url1 : UrlI1
	{
		private OriginI1 _origin;

		public OriginI1 origin
		{
			get { return _origin; }
			set { _origin = value; }
		}




		public Url1(OriginI1 origin, PathI path = null, Query query = null, Fragment frag = null)
		{
			_origin = origin;
			_path = path;
			_query = query;
			_fragment = frag;
		}

		public Url1(Scheme scheme, Authority1 radic1, Sprig sprig, Query query, Fragment frag)

		{
			
		}

		private _url.PathI _path;

		public _url.PathI path
		{
			get { return _path; }
			set { _path = value; }
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

		/// <summary>
		/// note for "http://abc.com" has to be normalzied as "http://abc.com/"
		/// </summary>
		/// <returns></returns>

		public override string ToString()
		{

			var sb = new StringBuilder();
			sb.Append(origin);

			if (_path!=null)
			{
				sb.Append($"{_url.Punctuators.AroundRadic}{_path}");

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

		static public Url1 CreateFroSchemeAuthority(string scheme, string authority)
		{
			return CreateFroSchemeAuthority(new Scheme(scheme), Authority1.Parse(authority));

		}

		static public Url1 CreateFroSchemeAuthority(Scheme scheme, Authority1 authority)
		{
			return CreateFroOrigin(new Origin(scheme, authority));

		}


		static public Url1 CreateFroOrigin(_url.Origin origin)
		{
			return new Url1(origin);

		}
	}
}