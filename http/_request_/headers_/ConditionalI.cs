using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.http._request_.headers_
{
	/*
	 Conditional GET Requests

In all the previous examples, the server returns the entire document if the request can be fulfilled (i.e. unconditional). You may use additional request header to issue a "conditional request". For example, to ask for the document based on the last-modified date (so as to decide whether to use the local cache copy), or to ask for a portion of the document (or range) instead of the entire document (useful for downloading large documents).

The conditional request headers include:
If-Modified-Since (check for response status code "304 Not Modified").
If-Unmodified-Since
If-Match
If-None-Match
If-Range

		 */
	interface ConditionalI
	{
	}
}
