using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.web._url._origin._authority._hostPort._host;
using nilnul.web._url._origin._authority._hostPort;
using nilnul.web._url_._authority_._socket_;
using nilnul.web._url._origin._authority._socket.host_.named_._domained;
using nilnul.web._url._origin._authority._socket.host_.named_._domained._domain._suffix;
using nilnul.web._url._origin._authority._socket.host_.named_._domained._domain.suffix_;
using nilnul.web._url._origin._authority._socket.host_.named_._domained._domain;

namespace nilnul.web._url._origin._authority._socket.host_.named_
{


	public abstract class DomainedA : DomainedI
	{
		public abstract Domain domain { get; }
		public abstract Prefix prefix { get; }
		static public DomainedA _Parse(string[] splitted)
		{
			//var splitted = txt.Split('.');

			if (splitted.Length == 2)
			{

				return host_.named_.NoPrefix.Parse(
					splitted[0]
					,
					splitted[1]
				);
				//brand

			}

			if (splitted.Length >= 3)
			{
				if (splitted.Last().Length > 2)
				{
					return new _url._origin._authority._socket.host_.named_.Domained(
						Prefix.Parse(splitted.Take(splitted.Length - 2))
						,
						new Domain(
							splitted[splitted.Length - 2]
							,
							splitted.Last()
						)
					);

				}
				if (splitted.Last().Length == 2)
				{
					var country = _domained._domain._suffix.Country.Parse(splitted.Last());

					if (
						named_._domained._domain._suffix._mission.txt.be_.Well.Singleton.be(
							splitted[splitted.Length - 2]
						)
					)
					{
						return new Domained(
							Prefix.Parse(splitted.Take(splitted.Length - 3))
							,
							new Domain(
							Brand.Parse(splitted[splitted.Length - 3])
							,
							new _domained._domain.suffix_.MissionCountry(

								_domained._domain._suffix.Mission.Parse(
									splitted[splitted.Length - 2]
									),
									country
								)
							)
						);

					}
					if (
						_domained._domain.suffix_._abbrCountry._abbr.txt.be_.Well.Singleton.be(
							splitted[splitted.Length - 2])
						)
					{
						return new Domained(

							Prefix.Parse(splitted.Take(splitted.Length - 3))
							,
							new Domain(
								Brand.Parse(
									splitted[splitted.Length - 3]
								)
							,
							new AbbrCountry(
								host_.named_._domained._domain.suffix_._abbrCountry.Abbr.Parse(
								splitted[splitted.Length - 2])
								,
								country
							)

							)
						);
					}

					return new Domained(
						Prefix.Parse(splitted.Take(splitted.Length - 2))
						,
						new Domain(
						Brand.Parse(splitted[splitted.Length - 2])
						,
						new host_.named_._domained._domain.suffix_.Country(country)
					));


				}

				throw new FormatException();
			}
			
			throw new FormatException();

		}

		static public DomainedA Parse(string txt)
		{

			return _Parse(txt.Split('.'));
		}
	}
}
