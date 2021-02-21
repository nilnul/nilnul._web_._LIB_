
using nilnul.web._url._origin._authority;

namespace nilnul.web._url._origin
{

	/// <summary>
	/// note：  in Standard or .Net, authority is socket(hostname  and portNumber)； whileas here it's bounded with credential.
	/// where the authority component divides into three subcomponents: 
	///authority = [userinfo@] host[:port]
	/// </summary>
	public interface AuthorityI2
	{
		Credential1 credential { get; set; }
		Socket socket { get; set; }
	}
}