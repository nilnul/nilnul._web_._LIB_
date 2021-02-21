using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.http
{
	/// <summary>
	/// </summary>
	public class Header
	{
		public const string ContentDisposition = "Content-Disposition";
	}

	/*
 HTTP header names may consist of any ASCII character apart from ASCII control characters and 19 listed separators.

   separators     = "(" | ")" | "<" | ">" | "@"
                  | "," | ";" | ":" | "\" | <">
                  | "/" | "[" | "]" | "?" | "="
                  | "{" | "}" | SP | HT

HTTP header values may contain any ISO-8859-1 character, though many of them needed to be transmitted within quotes. (The section marker character § is code 00A7 in ISO-8859-1 ... so that should be valid.)

Refer to the HTTP 1.1 spec (section 2.2 and section 4.2) for more details.

(The issue of escaping in headers is murky. I think that you can use RFC2047 encoding in header names, but it appears that it is not valid in header values. There is nothing to say that percent encoding is recognized (in general) in header values. See also: https://bugzilla.mozilla.org/show_bug.cgi?id=601933 which suggests that some web browsers may handle this inconsistently.)

	 
	 */

	/*
	 * 
	<META HTTP-EQUIV="Pragma" CONTENT="no-cache">
  <META HTTP-EQUIV="Cache-Control" CONTENT="no-cache">
  <META HTTP-EQUIV="Expires" CONTENT="0">

【 在 zxdong262 (zxd) 的大作中提到: 】
: 看看header里cache control怎么定义的
: --来自微水木3.2.0

--

※ 来源:·水木社区 http://newsmth.net·[FROM: 119.145.141.*]



[本篇全文] [回复文章] [本篇作者：zxdong262] [回信给作者] [进入讨论区] [返回顶部][分享到 搜狐微博 腾讯微博 新浪微博]
4

发信人: zxdong262 (zxd), 信区: WebDev
标  题: Re: HTML脚本里放了去缓存的Meta代码，但无效怎么办？
发信站: 水木社区 (Tue Nov 22 15:16:28 2016), 站内

从浏览器控制台看response的header
【 在 woaipinr 的大作中提到: 】
: <META HTTP-EQUIV="Pragma" CONTENT="no-cache">
:   <META HTTP-EQUIV="Cache-Control" CONTENT="no-cache">
:   <META HTTP-EQUIV="Expires" CONTENT="0">
: ...................

--

※ 来源:·水木社区 http://www.newsmth.net·[FROM: 219.136.205.*]



[本篇全文] [回复文章] [本篇作者：dhcn] [回信给作者] [进入讨论区] [返回顶部][分享到 搜狐微博 腾讯微博 新浪微博]
5

发信人: dhcn (小石), 信区: WebDev
标  题: Re: HTML脚本里放了去缓存的Meta代码，但无效怎么办？
发信站: 水木社区 (Tue Nov 22 15:21:17 2016), 站内

HTML中定义的Meta优先级低于response header中的优先级。
【 在 woaipinr 的大作中提到: 】
: 现在的浏览器是怎么了？
: - 来自最水木 -

	or no-store not no-cache?

	 * 
	 * */
}
