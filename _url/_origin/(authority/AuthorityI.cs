using nilnul.web._url._origin._authority;
using System;

namespace nilnul.web._url
{

	/// <summary>
	/// note：  in Standard or .Net, authority is socket(hostname  and portNumber)； whileas here it's bounded with credential.
	/// 
	/// </summary>
	/// 
	[Obsolete()]
	public interface AuthorityI
	{
		Credential credential { get; set; }
		HostPort hostPort { get; set; }
	}
}