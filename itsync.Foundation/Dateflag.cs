using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itsync.Foundation.helper
{
	/// <summary>
	/// 描述一个带有标志符号的日期。
	/// </summary>
	public class Dateflag
	{
		/// <summary>
		/// 描述本日期标识是否有效。
		/// true	- 有效
		/// false	- 无效(缺省值)
		/// </summary>
		public bool Available { set; get; }

		/// <summary>
		/// 描述本日期标识的具体日期和时间。
		/// </summary>
		public DateTime Value { set; get; }

		public Dateflag()
		{
			this.Available = false;
			this.Value = DateTime.Now;
		}

		public Dateflag(DateTime tmValue)
		{
			this.Available = true;
			this.Value = tmValue;
		}
	}
}
