using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url.hostRoute_
{
	public class HostStem
	{
		private nilnul.web._url._origin._authority._socket.HostI1 _host;

		public nilnul.web._url._origin._authority._socket.HostI1 host
		{
			get { return _host; }
			set { _host = value; }
		}

		private nilnul.web._url._resource._render.route_.Stem _stem;

		public nilnul.web._url._resource._render.route_.Stem stem
		{
			get { return _stem; }
			set { _stem = value; }
		}

		public override string ToString()
		{
			return $"{_host}{_stem}";
		}

	}
}
