using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.table.phrase_
{
	/// <summary>
	/// dt means datatables.net Domain. it's a jquery plug-in.
	/// </summary>
	static public class _Json4Dt
	{
		static public string Phrase(DataTable table) {
			return Newtonsoft.Json.JsonConvert.SerializeObject(

				new {
					data=  nilnul.obj.table.Rows.ToArr(table).Select(x=>x.ItemArray)
					,
					columns = table.Columns.OfType<DataColumn>().Select(x=> new {name=x.ColumnName, title=x.Caption })

				}
			);
		}

		static public string Phrase_nameIsCaption(DataTable table) {
			return Newtonsoft.Json.JsonConvert.SerializeObject(

				new {
					data=  nilnul.obj.table.Rows.ToArr(table).Select(x=>x.ItemArray)
					,
					columns = table.Columns.OfType<DataColumn>().Select(x=> new {name=x.Caption, title=x.ColumnName })

				}
			);
		}

	}
}
