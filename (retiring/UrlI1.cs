using nilnul.web._url;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web
{
	/// <summary>
	/*
	    A scheme. The scheme identifies the protocol to be used to access the resource on the Internet. It can be HTTP (without SSL) or HTTPS (with SSL).
    A host. The host name identifies the host that holds the resource. For example, www.example.com. A server provides services in the name of the host, but hosts and servers do not have a one-to-one mapping. Refer to Host names.

    Host names can also be followed by a port number. Refer to Port numbers. Well-known port numbers for a service are normally omitted from the URL. Most servers use the well-known port numbers for HTTP and HTTPS , so most HTTP URLs omit the port number.
    A path. The path identifies the specific resource in the host that the web client wants to access. For example, /software/htp/cics/index.html.
    A query string. If a query string is used, it follows the path component, and provides a string of information that the resource can use for some purpose (for example, as parameters for a search or as data to be processed). The query string is usually a string of name and value pairs; for example, term=bluebird. Name and value pairs are separated from each other by an ampersand (&); for example, term=bluebird&source=browser-search.

The scheme and host components of a URL are not defined as case-sensitive, 
but the path and query string are case-sensitive. Typically, the whole URL is specified in lowercase.


The components of the URL are combined and delimited as follows:

scheme://host:port/path?query

    The scheme is followed by a colon and two forward slashes.
    If a port number is specified, that number follows the host name, separated by a colon.
    The path name begins with a single forward slash.
    If a query string is specified, it is preceded by a question mark.

	*/
	/// </summary>
	/// <remarks>
	/// 
	/// 
	/* More generally speaking, here are the different parts of a URL, as per window.location. (So at least according to how Javascript calls it)

protocol://username:password@hostname:port/pathname?search#hash
-----------------------------href------------------------------
                             -----host----
-----------      origin      -------------
protocol - protocol scheme of the URL, including the final ':' 
hostname - domain name
port - port number
pathname - /pathname
search - ? parameters
hash - #fragment_identifier 
username - username specified before the domain name
password - password specified before the domain name
href - the entire URL
origin - protocol://hostname:port 
host - hostname:port
Formal definition is in RFC 6454 section 4.

	*/
	/// </remarks>

	public interface UrlI1
	{
		OriginI1 origin { get; }
		PathI path { get; }
		
		Query query { get; set; }

		Fragment fragment { get; set; }


	}


}
