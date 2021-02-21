using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.url.fro_
{
	/// <summary>
	/// 
	/// </summary>
	/// 
	[Obsolete(nameof(nilnul.web.url._ParseX))]
	public class Txt
	{
		

		static public Url Parse(string s) {
			var schemeEnd = s.IndexOf(_url.Punctuators.EndScheme);

			if (schemeEnd<0)
			{
				throw new nilnul.exception_.ParseException();
			}
			var scheme = _url.scheme.fro_.Txt.Parse(s.Substring(0, schemeEnd));

			var remainder = s.Substring(schemeEnd);

			nilnul.txt.eq.Aver aver = new txt.eq.Aver("//");



			aver.aver(remainder.Substring(0,2), new nilnul.exception_.ParseException());


			remainder = remainder.Substring(2);


			var radicEnd = remainder.IndexOf(_url.Punctuators.AroundRadic);



			

			if (radicEnd<0)
			{
				radicEnd = remainder.Length;	
			}

			var radic = _url.Authority.Parse( remainder.Substring(0, radicEnd));

			remainder = remainder.Substring(radicEnd);//empty if arg is length

			if (remainder.Length==0)
			{
				return new Url(
					scheme
					,
					radic
				);

			}

			_url.Fragment frag=null;
			var fragIntro = remainder.LastIndexOf('#');

			if (fragIntro>=0)
			{
				frag = new _url.Fragment(remainder.Substring(fragIntro));

				remainder = remainder.Substring(0, fragIntro);
			}

			_url.Query query = null;

			if (remainder.Length!=0)
			{
				var queryBegin = remainder.LastIndexOf('?');
				if (queryBegin>=0)
				{
				query = _url.Query.Parse( remainder.Substring(0, queryBegin));
				remainder = remainder.Substring(0, queryBegin);	

				}


			}

			_url.Sprig sprig = null;

			if (remainder.Length !=0)
			{

				nilnul.txt.be.Aver.BeginWith(remainder,"/");
				sprig = _url.Sprig.Parse(remainder.Substring(1));

			}

			return new Url(
				scheme
				,
				radic
				,
				sprig
				,
				query
				,
				frag	
			);







			


		}



	}
}
