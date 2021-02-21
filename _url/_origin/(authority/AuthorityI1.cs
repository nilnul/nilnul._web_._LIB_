using nilnul.web._url_._authority_;
using System;

namespace nilnul.web._url
{

	/// <summary>
	/// note：  in Standard or .Net, authority is socket(hostname  and portNumber)； whileas here it's bounded with credential.
	/// where the authority component divides into three subcomponents: 
	///authority = [userinfo@] host[:port]
	/// </summary>
	/// 
	[Obsolete()]
	public interface AuthorityI1
	{
		Credential credential { get; set; }
		Socket socket { get; set; }
	}
}