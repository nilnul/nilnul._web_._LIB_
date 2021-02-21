using nilnul.web._url;
using nilnul.web._url._origin._authority._hostPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.web._url_._authority_._socket_;

namespace nilnul.web._url_._authority_
{
	/// <summary>
	/// The correct answer is socket per the TCP/IP specification (RFC 793).
	///To allow for many processes within a single Host to use TCP communication facilities simultaneously, the TCP provides a set of addresses or ports within each host.Concatenated with the network and host addresses from the internet communication layer, this forms a socket.
 ///  http://www.faqs.org/rfcs/rfc793.html
	/// </summary>
	/// 
	[Obsolete()]
	public class Socket
	{
		public const char Separator = ':';
		private  _socket_.HostI _host;

		public _socket_.HostI host
		{
			get { return _host; }
			set { _host = value; }
		}

		private _authority_._socket_.Port _port;

		public _socket_.Port port
		{
			get { return _port; }
			set { _port = value; }
		}

		public Socket(_socket_.HostI host, _socket_.Port port)
		{
			_host = host;
			_port = port;
		}

		public Socket(string host, int v)
			:this(
				 _socket_.HostA.Parse(host)
				 , _socket_.Port.Create(v)
				 
			)
		{

		}

		public Socket(_socket_.Host host1, int port1)
			:this(host1 as _socket_.HostI, new _socket_.Port(port1))
		{
		}

		public override string ToString()
		{
			if (_port==null)
			{
			return $"{_host}";


			}
			return $"{_host}:{_port}";
		}

		static public Socket Parse(string txt) {

			var splitted = txt.Split(Separator);

			if (splitted.Length==1)
			{
				return new Socket(
					_socket_.HostA.Parse(txt)
					,
					null
					
				);
			}
			if (splitted.Length==2)
			{
				return new Socket(
					_socket_.HostA.Parse(splitted[0])
					,
					_socket_.Port.Parse(splitted[1])	
				);

			}

			throw new nilnul.exception_.ParseException();
		}

	}
}
