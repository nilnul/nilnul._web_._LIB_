using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace nilnul._web._data
{
	/// <summary>
	/// 
	/// </summary>
	public class Err
	{
		static public JavaScriptSerializer jsonizer = new System.Web.Script.Serialization.JavaScriptSerializer();
		static public string CreateJson(string msg, int code)
		{
			if (string.IsNullOrWhiteSpace(msg))
			{
				return jsonizer.Serialize(
					new {

					}
				);
			}
			return jsonizer.Serialize(
				new
				{

					msg = msg
						,
					code = code

				}
			);
		}

		static public object CreateObj(string msg, int code)
		{
			
			return 
				new
				{

					msg = msg
						,
					code = code

				}
			;
		}
		static public object CreateObj(string msg, int code, object data)
		{
			
			return 
				new
				{

					msg = msg
						,
					code = code
					,
					data=data

				}
			;
		}



		static public object CreateObj(string msg)
		{

			return
				new
				{

					msg = msg

				}
			;
		}


	}
}
