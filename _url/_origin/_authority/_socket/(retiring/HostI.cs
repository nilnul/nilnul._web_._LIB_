﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.web._url._origin._authority._hostPort._host;

namespace nilnul.web._url._origin._authority._hostPort
{
	/// <summary>
	/// abc.wyt.nilnul.com.cn. excuding port.
	/// </summary>
	/// <remarks>
	/// www - Server-Name (subdomain) 
///example - Second Level Domain(SLD)
///com - Top Level Domain(TLD)
	/// </remarks>
	/// 
	[Obsolete()]
	public interface HostI
	{
		 _host.Prefix prefix { get; }

		_host.Brand brand { get; }
		_host.SuffixI suffix { get; }



	}

}
