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
	public class _ParseX3
	{
		static public Url3 Parse(string s) {
			var schemeEnd = s.IndexOf(_url.Punctuators.EndScheme);

			if (schemeEnd<0)
			{
				throw new nilnul.exception_.ParseException("not find colon(:) to end scheme.");
			}
			var scheme = _url.scheme.fro_.Txt.Parse(s.Substring(0, schemeEnd));

			var toBeParsed = s.Substring(schemeEnd+1);


			nilnul.txt.eq.Aver aver = new txt.eq.Aver("//");

			aver.aver(toBeParsed.Substring(0,2), new nilnul.exception_.ParseException());


			toBeParsed = toBeParsed.Substring(2);

			var authEnd = toBeParsed.IndexOf(_url.Punctuators.AroundRadic);  //aka: route deck


			if (authEnd<0)
			{
				return  Url3.CreateFroSchemeAuthority(
					scheme
					,
					_url._origin.Authority2.Parse(toBeParsed)
				);
			}
			
			var authorityTxt = toBeParsed.Substring(0, authEnd);

			var authority = _url._origin.Authority2.Parse( authorityTxt);



			toBeParsed = toBeParsed.Substring(authEnd+1);//division, not route, included

			//if (henceAuth.Length==0)
			//{
			//	return  Url2.CreateFroSchemeAuthority(
			//		scheme
			//		,
			//		authority
			//	);

			//}

			_url.Fragment frag=null;
			var fragIntro = toBeParsed.LastIndexOf('#');	//parsed from back to forth

			if (fragIntro>=0)
			{
				frag = new _url.Fragment(toBeParsed.Substring(fragIntro+1));

				toBeParsed = toBeParsed.Substring(0, fragIntro);
			}

			_url.Query query = null;

			//if (toBeParsed.Length!=0)
			//{
				var queryBegin = toBeParsed.LastIndexOf('?');
				if (queryBegin>=0)
				{
					query = _url.Query.Parse(toBeParsed.Substring(queryBegin+1));
					toBeParsed = toBeParsed.Substring(0, queryBegin);	

				}

			//}

			//_url.DivisionI division = null;
			//if (toBeParsed.Length !=0)
			//{
				//nilnul.txt.be.Aver.BeginWith(toBeParsed, "/");
				var division = _url._resource._render._route.division._ParseX.Parse(toBeParsed);
			//}

			return new Url3(

				scheme
				,
				authority
				,
				new _url._resource._render.Route(
					division
				)
				,
				query
				,
				frag	
			);
		}
	}
}