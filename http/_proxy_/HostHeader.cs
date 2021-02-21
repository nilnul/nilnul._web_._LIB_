using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.http._proxy_
{
	/*
	 Issue a GET Request through a Proxy Server

To send a GET request through a proxy server, (a) establish a TCP connection to the proxy server; (b) use an absolute request-URI http://hostname:port/path/fileName to the target server.

The following trace was captured using telnet. A connection is established with the proxy server, and a GET request issued. Absolute request-URI is used in the request line.
GET http://www.amazon.com/index.html HTTP/1.1
Host: www.amazon.com
Connection: Close
(blank line)

		 */
	public interface HostHeaderI
	{
	}
}
