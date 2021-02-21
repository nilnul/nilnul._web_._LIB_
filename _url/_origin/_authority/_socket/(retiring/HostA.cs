using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.web._url._origin._authority._hostPort._host;

namespace nilnul.web._url._origin._authority._hostPort
{
	
	[Obsolete()]
	public abstract class HostA:HostI
	{
		public abstract Brand brand { get; }
		public abstract Prefix prefix { get; }
		public abstract SuffixI suffix { get; }

		static public HostA Parse(string txt)
		{
			var splitted = txt.Split('.');

			if (splitted.Length == 2)
			{

				return host_.NoPrefix.Parse(
					splitted[0]
					,
					splitted[1]	
				);
				//brand
				
			}

			if (splitted.Length>=3)
			{
				if (splitted.Last().Length>2)
				{
					return new Host1(
						_host.Prefix.Parse(splitted.Take(splitted.Length-2))
						,
						_host.Brand.Parse(splitted[splitted.Length-2])
						,
						_host.suffix_.Mission.Parse(splitted.Last())
					);

				}
				if (splitted.Last().Length==2)
				{
					var country = _host._suffix.Country.Parse(splitted.Last());

					if (
						nilnul.web._url_._authority_._socket_._host_._domain_._suffix_._mission.txt.be_.Well.Singleton.be(
							splitted[splitted.Length-2]
						)
					)
					{
						return new Host1(
							_host.Prefix.Parse(splitted.Take(splitted.Length - 3))
							,
							_host.Brand.Parse(splitted[splitted.Length - 3])
							,
							new _host.suffix_.MissionCountry(

								_host._suffix.Mission.Parse(
									splitted[splitted.Length - 2]
								), 
								country
							)
						);

					}
					if (
						_host.suffix_._abbrCountry._abbr.txt.be_.Well.Singleton.be(
							splitted[splitted.Length-2])
						)
					{
						return new Host1(

							_host.Prefix.Parse(splitted.Take(splitted.Length-3))
							,
							_host.Brand.Parse(splitted[splitted.Length-3])
							,
							new _host.suffix_.AbbrCountry(
								_host.suffix_._abbrCountry.Abbr.Parse(
								splitted[splitted.Length-2])
								,
								country
							)
								
						);
					}

					return new Host1(
						_host.Prefix.Parse(splitted.Take(splitted.Length-2))
						,
						_host.Brand.Parse(splitted[splitted.Length-2])	
						,
						new _host.suffix_.Country(country)
					);


				}

				throw new FormatException();
			}
			throw new FormatException();

		}
	}
}
