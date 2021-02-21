using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.web._url._origin._authority._hostPort._host;
using nilnul.web._url._origin._authority._hostPort;
using nilnul.web._url_._authority_._socket_;

namespace nilnul.web._url_._authority_._socket_
{

	[Obsolete()]
	public abstract class HostA : HostI
	{
		public abstract _host_.Domain domain { get; }
		public abstract _host_.Prefix prefix { get; }

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

			if (splitted.Length >= 3)
			{
				if (splitted.Last().Length > 2)
				{
					return new Host(
						_host_.Prefix.Parse(splitted.Take(splitted.Length - 2))
						,
						new _host_.Domain(
							splitted[splitted.Length - 2]
							,
							splitted.Last()
						)
					);

				}
				if (splitted.Last().Length == 2)
				{
					var country = _host_._domain_._suffix_.Country.Parse(splitted.Last());

					if (
						_host_._domain_._suffix_._mission.txt.be_.Well.Singleton.be(
							splitted[splitted.Length - 2]
						)
					)
					{
						return new Host(
							_host_.Prefix.Parse(splitted.Take(splitted.Length - 3))
							,
							new _host_.Domain(
							_host_._domain_.Brand.Parse(splitted[splitted.Length - 3])
							,
							new _host_._domain_.suffix_.MissionCountry(

								_host_._domain_._suffix_.Mission.Parse(
									splitted[splitted.Length - 2]
									),
									country
								)
							)
						);

					}
					if (
						_host_._domain_.suffix_._abbrCountry_._abbr.txt.be_.Well.Singleton.be(
							splitted[splitted.Length - 2])
						)
					{
						return new Host(

							_host_.Prefix.Parse(splitted.Take(splitted.Length - 3))
							,
							new _host_.Domain(
								_host_._domain_.Brand.Parse(
									splitted[splitted.Length - 3]
								)
							,
							new _host_._domain_.suffix_.AbbrCountry(
								_host_._domain_.suffix_._abbrCountry_.Abbr.Parse(
								splitted[splitted.Length - 2])
								,
								country
							)

							)
						);
					}

					return new Host(
						_host_.Prefix.Parse(splitted.Take(splitted.Length - 2))
						,
						new _host_.Domain(
						_host_._domain_.Brand.Parse(splitted[splitted.Length - 2])
						,
						new _host_._domain_.suffix_.Country(country)
					));


				}

				throw new FormatException();
			}
			throw new FormatException();

		}
	}
}
