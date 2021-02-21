using nilnul.web._url;
using nilnul.web._url._origin._authority._hostPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.web._url_._authority_._socket_;

namespace nilnul.web._url._origin._authority.socket_
{
	/// <summary>
	/// The correct answer is socket per the TCP/IP specification (RFC 793).

	///To allow for many processes within a single Host to use TCP communication facilities simultaneously, the TCP provides a set of addresses or ports within each host.Concatenated with the network and host addresses from the internet communication layer, this forms a socket.

 ///  http://www.faqs.org/rfcs/rfc793.html

	/// </summary>
	public class Domained
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

		public Domained(_socket.host_.named_.DomainedI host, _socket.Port port)
		{
			_host = host;
			_port = port;
		}

		public Domained(string host, int v)
			:this(
				  _socket.host_.named_.DomainedA.Parse(host)
				 , _socket.Port.Create(v)
				 
			)
		{

		}

		public Domained(_socket.host_.named_.Domained host1, int port1)
			:this(host1 as _socket.host_.named_.DomainedI, new _socket.Port(port1))
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

		static public Domained Parse(string txt) {

			var splitted = txt.Split(Separator);

			if (splitted.Length==1)
			{
				return new Domained(
					_socket.host_.named_.DomainedA.Parse(txt)
					,
					null
					
				);
			}
			if (splitted.Length==2)
			{
				return new Domained(
					_socket.host_.named_.DomainedA.Parse(splitted[0])
					,
					_socket.Port.Parse(splitted[1])	
				);

			}

			throw new nilnul.exception_.ParseException();
		}

	}
}
