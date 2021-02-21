using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.web._url._origin._authority._hostPort._host;
using nilnul.web._url._origin._authority._socket.host_.named_._domained;

namespace nilnul.web._url._origin._authority._socket.host_.named_
{
	/// <summary>
	/// abc.wyt.nilnul.com.cn. excuding port.
	/// </summary>
	/// <remarks>
	/// www - Server-Name (subdomain) 
///example - Second Level Domain(SLD)
///com - Top Level Domain(TLD)
	/// </remarks>
	public interface DomainedI:NamedI
	{
		 Prefix prefix { get; }

		Domain domain { get; }



	}

}
