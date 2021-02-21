using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._txt.character.be_
{
	/// <summary>
	/// That leaves only the following ASCII characters that are forbidden from appearing in a URL:
	/// •The control characters(chars 0-1F and 7F), including new line, tab, and carriage return.
	/// • "<>\^`{|}

	/// </summary>
	public class Invalid
	{
	}

	/*
	 First of all, we have two types of RFC 3986 reserved characters:
•:/?#[]@, which are part of the generic syntax for a URI defined in RFC 3986
•!$&'()*+,;=, which aren't part of the RFC's generic syntax, but are reserved for use as syntactic components of particular URI schemes. For instance, semicolons and commas are used as part of the syntax of data URIs, and & and = are used as part of the ubiquitous ?foo=bar&qux=baz format in query strings (which isn't specified by RFC 3986).

Any of the reserved characters above can be legally used in a URI without encoding, either to serve their syntactic purpose or just as literal characters in data in some places where such use could not be misinterpreted as the character serving its syntactic purpose. (For example, although / has syntactic meaning in a URL, you can use it unencoded in a query string, because it doesn't have meaning in a query string.)

RFC 3986 also specifies some unreserved characters, which can always be used simply to represent data without any encoding:
•abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._~

Finally, the % character itself is allowed for percent-encodings.

That leaves only the following ASCII characters that are forbidden from appearing in a URL:
•The control characters (chars 0-1F and 7F), including new line, tab, and carriage return.
• "<>\^`{|}

	Every other character from ASCII can legally feature in a URL.

Then RFC 3987 extends that set of unreserved characters with the following unicode character ranges:
  %xA0-D7FF / %xF900-FDCF / %xFDF0-FFEF
/ %x10000-1FFFD / %x20000-2FFFD / %x30000-3FFFD
/ %x40000-4FFFD / %x50000-5FFFD / %x60000-6FFFD
/ %x70000-7FFFD / %x80000-8FFFD / %x90000-9FFFD
/ %xA0000-AFFFD / %xB0000-BFFFD / %xC0000-CFFFD
/ %xD0000-DFFFD / %xE1000-EFFFD


But those block choices seem bizarre and arbitrary given the latest Unicode block definitions; this is probably because the blocks have been added to in the decade since RFC 3987 was written. The WhatWG's in-progress spec has a more generous list:


U+00A0 to U+D7FF, U+E000 to U+FDCF, U+FDF0 to U+FFFD, U+10000 to U+1FFFD, U+20000 to U+2FFFD, U+30000 to U+3FFFD, U+40000 to U+4FFFD, U+50000 to U+5FFFD, U+60000 to U+6FFFD, U+70000 to U+7FFFD, U+80000 to U+8FFFD, U+90000 to U+9FFFD, U+A0000 to U+AFFFD, U+B0000 to U+BFFFD, U+C0000 to U+CFFFD, U+D0000 to U+DFFFD, U+E0000 to U+EFFFD, U+F0000 to U+FFFFD, U+100000 to U+10FFFD

Of course, it should be noted that simply knowing which characters can legally appear in a URL isn't sufficient to recognise whether some given string is a legal URL or not, since some characters are only legal in particular parts of the URL. For example, the reserved characters [ and ] are legal as part of an IPv6 literal host in a URL like http://[1080::8:800:200C:417A]/foo but aren't legal in any other context, so the OP's example of http://example.com/file[/].html is illegal.

	 */
}
