using nilnul.web._url._origin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// https://tools.ietf.org/html/rfc6454#section-4
	/// </remarks>
	public interface OriginI2
	{
		Scheme scheme { get; }
		AuthorityI2 authority { get; }
	}
}
