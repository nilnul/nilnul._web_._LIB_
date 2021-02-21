using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// https://tools.ietf.org/html/rfc6454#section-4
	/// </remarks>
	/// 
	[Obsolete(nameof(OriginI1))]
	public interface OriginI
	{
		Scheme scheme { get; }
		Authority authority { get; }
	}
}
