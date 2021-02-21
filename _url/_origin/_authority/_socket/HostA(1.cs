using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.web._url._origin._authority._hostPort._host;
using nilnul.web._url._origin._authority._hostPort;
using nilnul.web._url_._authority_._socket_;

namespace nilnul.web._url._origin._authority._socket
{


	public abstract class HostA : HostI1
	{
		

		static public HostI1 Parse(string txt)
		{
			var splitted = txt.Split('.');
			if (splitted.Length>=2)
			{
				return host_.named_.DomainedA._Parse(splitted);
			}
			if (splitted.Length==1) //such as localhost
			{
				return new Host3(splitted.First());
			}
			throw new FormatException();

		}
	}
}
