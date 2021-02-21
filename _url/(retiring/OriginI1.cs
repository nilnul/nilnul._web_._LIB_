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
	/// 
	[Obsolete()]
	public interface OriginI1
	{
		Scheme scheme { get; }
		Authority1 authority { get; }
	}
}
