using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._resource._render.route_
{
	/// <summary>
	/// Formally known as Path in standard. Path is the rooted; or route
	/// for "http://abc.com", the sprig is null
	/// for "http://abc.com/", the sprig is ""
	/// for "http://abc.com/a", the sprig is "a"
	/// for "http://abc.com/a/", the sprig is "a/"
	/// for "http://abc.com/a/b", the sprig is "a/b"
	/// 
	/// sprout first, so the above will first be parsed from rear into a sprout, the the remaining is stem.
	/// </summary>
	/// 
	[Obsolete(nameof(Route))]
	public class Sprig
	{
		public const char SEPARATOR = '/';
		private _sprig.Stem _stem;

		public _sprig.Stem stem
		{
			get { return _stem; }
			set { _stem = value; }
		}

		/// <summary>
		/// sprout first.
		/// </summary>
		private _sprig.Sprout _sprout;

		public _sprig.Sprout sprout
		{
			get { return _sprout; }
			set { _sprout = value; }
		}

		public Sprig(_sprig.Stem stem, _sprig.Sprout sprout)
		{
			_stem = stem;
			_sprout = sprout;
		}

		public override string ToString()
		{
			
			

			if (_stem.beEmpty)
			{
			

				return _sprout.ToString();

			}

			return $"{_stem}{SEPARATOR}{_sprout}";
		}

		static public Sprig Parse(string txt) {
			var splitted = txt.Split('/');
			if (splitted.Length==1)
			{
				return new Sprig(
					new _sprig.Stem()
					,
						
					 _sprig.Sprout.Parse(txt)
				);
			}

			return new Sprig(
				new _sprig.Stem(splitted.Take(splitted.Length-1).Select(t=>_sprig.Dst.Parse(t)))
				,
				_sprig.Sprout.Parse(splitted.Last())	
			);
			
		}
	}
}
