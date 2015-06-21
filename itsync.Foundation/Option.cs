using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itsync.Foundation
{
	/// <summary>
	/// 描述一个产品中的功能选件。
	/// </summary>
	public class Option : Item
	{
		/// <summary>
		/// 描述这个选件的编码。
		/// </summary>
		public string Code { set; get; }

		public Option()
			: base()
		{
			this.Code = "";
		}

		public Option(string szCode)
			: base()
		{
			this.Code = szCode;
		}
	}
}
