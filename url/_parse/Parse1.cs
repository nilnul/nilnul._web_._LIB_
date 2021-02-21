using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.url
{
	/// <summary>
	/// 
	/// </summary>
	/// 
	[Obsolete()]
	public class _ParseX1
	{
		

		static public Url1 Parse(string s) {
			var schemeEnd = s.IndexOf(_url.Punctuators.EndScheme);

			if (schemeEnd<0)
			{
				throw new nilnul.exception_.ParseException();
			}
			var scheme = _url.scheme.fro_.Txt.Parse(s.Substring(0, schemeEnd));

			var aftScheme = s.Substring(schemeEnd);

			nilnul.txt.eq.Aver aver = new txt.eq.Aver("//");



			aver.aver(aftScheme.Substring(0,2), new nilnul.exception_.ParseException());


			aftScheme = aftScheme.Substring(2);


			var radicEnd = aftScheme.IndexOf(_url.Punctuators.AroundRadic);



			

			if (radicEnd<0)
			{
				radicEnd = aftScheme.Length;	
			}

			var authorityTxt = aftScheme.Substring(0, radicEnd);
			var radic1 = _url.Authority1.Parse(authorityTxt);

			var radic = _url.Authority.Parse( authorityTxt);

			aftScheme = aftScheme.Substring(radicEnd);//empty if arg is length

			if (aftScheme.Length==0)
			{
				return  Url1.CreateFroSchemeAuthority(
					scheme
					,
					radic1
				);

			}

			_url.Fragment frag=null;
			var fragIntro = aftScheme.LastIndexOf('#');

			if (fragIntro>=0)
			{
				frag = new _url.Fragment(aftScheme.Substring(fragIntro));

				aftScheme = aftScheme.Substring(0, fragIntro);
			}

			_url.Query query = null;

			if (aftScheme.Length!=0)
			{
				var queryBegin = aftScheme.LastIndexOf('?');
				if (queryBegin>=0)
				{
				query = _url.Query.Parse( aftScheme.Substring(0, queryBegin));
				aftScheme = aftScheme.Substring(0, queryBegin);	

				}


			}

			_url.Sprig sprig = null;

			if (aftScheme.Length !=0)
			{

				nilnul.txt.be.Aver.BeginWith(aftScheme,"/");
				sprig = _url.Sprig.Parse(aftScheme.Substring(1));


			}

			return new Url1(

				scheme
				,
				radic1
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
