using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.http.session_
{
	/*
	 GET Request for Directory

		for some server such as apache

Suppose that a directory called "testdir" is present in the document base directory "htdocs".

If a client issues a GET request to "/testdir/" (i.e., at the directory).
1.The server will return "/testdir/index.html" if the directory contains a "index.html" file.
2.Otherwise, the server returns the directory listing, if directory listing is enabled in the server configuration.
3.Otherwise, the server returns "404 Page Not Found".

It is interesting to take note that if a client issue a GET request to "/testdir" (without specifying the directory path "/"), the server returns a "301 Move Permanently" with a new "Location" of "/testdir/", as follows.
GET /testdir HTTP/1.1
Host: 127.0.0.1
(blank line)
HTTP/1.1 301 Moved Permanently
Date: Sun, 18 Oct 2009 13:19:15 GMT
Server: Apache/2.2.14 (Win32)
Location: http://127.0.0.1:8000/testdir/
Content-Length: 238
Content-Type: text/html; charset=iso-8859-1
   
<!DOCTYPE HTML PUBLIC "-//IETF//DTD HTML 2.0//EN">
<html><head>
<title>301 Moved Permanently</title>
</head><body>
<h1>Moved Permanently</h1>
<p>The document has moved <a href="http://127.0.0.1:8000/testdir/">here</a>.</p>

</body></html>

Most of the browser will follow up with another request to "/testdir/". For example, If you issue http://127.0.0.1:8000/testdir without the trailing "/" from a browser, you could notice that a trailing "/" was added to the address after the response was given. The morale of the story is: you should include the "/" for directory request to save you an additional GET request. 

		 */
	interface GetFolder
	{
	}
}
