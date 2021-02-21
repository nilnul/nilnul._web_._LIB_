using nilnul.web._url;
using nilnul.web._url._origin._authority._hostPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.web._url_._authority_._socket_;

namespace nilnul.web._url._origin._authority
{
	/// <summary>
	/// The correct answer is socket per the TCP/IP specification (RFC 793).

	///To allow for many processes within a single Host to use TCP communication facilities simultaneously, the TCP provides a set of addresses or ports within each host.Concatenated with the network and host addresses from the internet communication layer, this forms a socket.

 ///  http://www.faqs.org/rfcs/rfc793.html

	/// </summary>
	public class Socket
	{
		public const char Separator = ':';
		private  _socket.HostI1 _host;

		public _socket.HostI1 host
		{
			get { return _host; }
			set { _host = value; }
		}

		private _authority._socket.Port _port;

		public _socket.Port port
		{
			get { return _port; }
			set { _port = value; }
		}

		public Socket(_socket.HostI1 host, _socket.Port port)
		{
			_host = host;
			_port = port;
		}
		public Socket(_socket.Host3 host1, _socket.Port port1)
			:this((_socket.HostI1)host1,(port1))
		{
		}
		public Socket(_socket.Host3 host1, int port1)
			:this((_socket.HostI1)host1, new _socket.Port(port1))
		{
		}

		public Socket(string host, int v)
			:this(
				 new _socket.Host3(host)
				 , _socket.Port.Create(v)
				 
			)
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
					new _socket.Host3(txt)
					,
					null
					
				);
			}
			if (splitted.Length==2)
			{
				return new Socket(
					new _socket.Host3(splitted[0])
					,
					_socket.Port.Parse(splitted[1])	
				);

			}

			throw new nilnul.exception_.ParseException();
		}

	}
}
