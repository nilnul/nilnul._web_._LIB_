using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace nilnul._web
{
	/// <summary>
	/// 
	/// </summary>
	public class Data
	{
		static public JavaScriptSerializer jsonizer = new System.Web.Script.Serialization.JavaScriptSerializer();
		static public string CreateErrJson(string msg, int code)
		{
			
			return jsonizer.Serialize(
				new
				{
					err =_data.Err.CreateObj(msg,code)

				}
			);
		}
		static public object CreateErr(string msg, int code)
		{
			
			return (
				new
				{
					err =_data.Err.CreateObj(msg,code)

				}
			);
		}

		static public string CreateErrJson(string msg, int code, object data)
		{
			
			return jsonizer.Serialize(
				new
				{
					err =_data.Err.CreateObj(msg,code,data)

				}
			);
		}
		static public Object CreateErr(string msg, int code, object data)
		{
			
			return (
				new
				{
					err =_data.Err.CreateObj(msg,code,data)

				}
			);
		}


		static public string CreateErrJson(string msg)
		{

			return jsonizer.Serialize(
				new
				{
					err = _data.Err.CreateObj(msg)

				}
			);
		}


		static public Object CreateErr(string msg)
		{

			return (
				new
				{
					err = _data.Err.CreateObj(msg)

				}
			);
		}



	}
}
