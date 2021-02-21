using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.Properties
{
	[Obsolete(nameof(Properties.settings._url.Origin))]
	static public class SettingsX
	{


		static public string _Origin
		{
			get
			{
				var s = Settings.Default;
				///it seems that if not set, the default value is used
				return (s.scheme??s.Properties[nameof(s.scheme)].DefaultValue) 
					+ "://" + (s.authority );

				//return (s.scheme??s.Properties[nameof(s.scheme)].DefaultValue) + "://" + (s.socket ?? s.Properties[nameof(s.socket)].DefaultValue);
			}
		}

		static public string _Root
		{
			get
			{
				
				return _Origin+ "/" ;
			}
		}


		static public string _AppSpear
		{
			get
			{
				
				return _Root+ "app_" ;
			}
		}

		static public string _AppShield
		{
			get
			{
				
				return _AppSpear+ "/" ;
			}
		}


	}
}
