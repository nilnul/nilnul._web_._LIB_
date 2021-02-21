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
	public class Url : UrlI
	{
		private _url.Scheme _scheme;

		public _url.Scheme scheme
		{
			get { return _scheme; }
			set { _scheme = value; }
		}

		private _url.Authority _authority;

		public _url.Authority authority
		{
			get { return _authority; }
			set { _authority = value; }
		}



		public Url( Scheme scheme, Authority radic, Sprig sprig=null, Query query=null, Fragment frag=null)
		{
			_scheme = scheme;
			_authority = radic;
			_sprig = sprig;
			_query = query;
			_fragment = frag;
		}


		

		private _url.Sprig _sprig;

		public _url.Sprig sprig
		{
			get { return _sprig; }
			set { _sprig = value; }
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
			return $"{_scheme}{_url.Punctuators.EndScheme}{_url.Punctuators.AroundRadic}{_url.Punctuators.AroundRadic}{_authority}{_url.Punctuators.AroundRadic}{_sprig}{_url.Punctuators.IntroQuery}{_query}{_url.Punctuators.IntroFragment}{_fragment}";
		}

		static public string CreateUrlTxtWithNoEndSlash(string scheme, string authority) {
			return $"{scheme}://{authority}";

		}

		static public Url CreateFroOrigin(string scheme, string authority) {
			return new Url( new Scheme(scheme),  Authority.Parse(authority));

		}

		



		/// <summary>
		/// see Uri.GetLeftPart
		/// </summary>
		/// <returns></returns>
		static public string TilInclude() {
			throw new NotFiniteNumberException();
		}
		



	}
}
