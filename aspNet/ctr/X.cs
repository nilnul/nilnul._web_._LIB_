using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Linq.Expressions;
using System.Collections;
using System.Web;
using System.Diagnostics;

namespace nilnul.web.aspNet.ctr
{
	static public class X
	{
		public static IEnumerable<T> FindControlsOfType<T>(this Control parent)
														where T : Control
		{
			foreach (Control child in parent.Controls)
			{
				if (child is T)
				{
					yield return (T)child;
				}
				else if (child.Controls.Count > 0)
				{
					foreach (T grandChild in child.FindControlsOfType<T>())
					{
						yield return grandChild;
					}
				}
			}

		}
		public static IEnumerable<UserControl> FindControlsOfPath(this Control parent, string path)

		{

			var r = new List<UserControl>();
			foreach (Control child in parent.Controls)
			{

				if (child is UserControl)
				{

					var uc = child as UserControl;
					Trace.WriteLine(uc.AppRelativeVirtualPath);//~/_bid/_sln/_sections/_method/_drillExplode/_veriSln/_digSimu/ref_iniSimu_fem.ascx

					
															  //~/_bid/_sln/_sections/_method/_drillExplode/_veriSln/_iniSimu/fig.eg/fem.ascx

					if (uc.AppRelativeVirtualPath == path)
					{

						r.Add(child as UserControl);

					}
					else
					{
						r.AddRange(FindControlsOfPath(child, path));

					}

				}

				else
				{

					r.AddRange(FindControlsOfPath(child, path));


				}
			}
			return r;

		}



		[PossibleException()]
		public static IEnumerable<Control> FindControlsOfRelPath(this UserControl parent, string relPath)

		{
			return parent.FindControlsOfPath(



				VirtualPathUtility.Combine(parent.AppRelativeVirtualPath, relPath)
			);

		}


	}
}
