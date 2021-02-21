using nilnul.web._url._authority._hostPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._authority
{
	/// <summary>
	/// The correct answer is socket per the TCP/IP specification (RFC 793).

	///To allow for many processes within a single Host to use TCP communication facilities simultaneously, the TCP provides a set of addresses or ports within each host.Concatenated with the network and host addresses from the internet communication layer, this forms a socket.

 ///  http://www.faqs.org/rfcs/rfc793.html

	/// </summary>
	public class Socket
	{
		public const char Separator = ':';
		private HostI _host;

		public HostI host
		{
			get { return _host; }
			set { _host = value; }
		}

		private Port1 _port;

		public Port1 port
		{
			get { return _port; }
			set { _port = value; }
		}

		public Socket(HostI host, Port1 port)
		{
			_host = host;
			_port = port;
		}

		public Socket(string dOMAIN2RECEIVE, int v)
			:this(
				 HostA.Parse(dOMAIN2RECEIVE)
				 , Port1.Create(v)
				 
			)
		{

		}

		public override string ToString()
		{
			return $"{_host}:{_port}";
		}

		static public Socket Parse(string txt) {

			var splitted = txt.Split(Separator);

			if (splitted.Length==1)
			{
				return new Socket(
					HostA.Parse(txt)
					,
					null
					
				);
			}
			if (splitted.Length==2)
			{
				return new Socket(
					HostA.Parse(splitted[0])
					,
					Port1.Parse(splitted[1])	
				);

			}

			throw new nilnul.exception_.ParseException();
		}

	}
}
