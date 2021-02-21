using nilnul.web._url._origin._authority._hostPort;
using nilnul.web._url_._authority_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._origin._authority
{
	/// <summary>
	/// app, service
	/// </summary>
	/// 
	[Obsolete(nameof(Socket))]
	public class HostPort
	{
		public const char Separator = ':';
		private HostI _host;

		public HostI host
		{
			get { return _host; }
			set { _host = value; }
		}

		private Port _port;

		public Port port
		{
			get { return _port; }
			set { _port = value; }
		}

		public HostPort(HostI host, Port port)
		{
			_host = host;
			_port = port;
		}

		public override string ToString()
		{
			return $"{_host}:{_port}";
		}

		static public HostPort Parse(string txt) {

			var splitted = txt.Split(Separator);

			if (splitted.Length==1)
			{
				return new HostPort(
					HostA.Parse(txt)
					,
					null
					
				);
			}
			if (splitted.Length==2)
			{
				return new HostPort(
					HostA.Parse(splitted[0])
					,
					Port.Parse(splitted[1])	
				);

			}

			throw new nilnul.exception_.ParseException();
		}

	}
}
