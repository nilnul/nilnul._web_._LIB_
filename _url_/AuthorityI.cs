using nilnul.web._url_._authority_;

namespace nilnul.web._url_
{

	/// <summary>
	/// note：  in Standard or .Net, authority is socket(hostname  and portNumber)； whileas here it's bounded with credential.
	/// where the authority component divides into three subcomponents: 
	///authority = [userinfo@] host[:port]
	/// </summary>
	public interface AuthorityI
	{
		Credential credential { get; set; }
		Socket socket { get; set; }
	}
}