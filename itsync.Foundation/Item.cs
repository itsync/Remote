using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itsync.Foundation
{
	/// <summary>
	/// 描述一个条目及其所对应的值。
	/// </summary>
	public class Item : Object
	{
		/// <summary>
		/// 本条目所对应的值。
		/// 其长度不超过1024个英文字符。
		/// </summary>
		public string Value { set; get; }

		public Item()
			: base()
		{
			this.Value = "";
		}

		public Item(Guid uiGuid, string szName, string szDescription, string szValue) :
			base(uiGuid, szName, szDescription)
		{
			this.Value = szValue;
		}
	}

}

