using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using itsync.Foundation.helper;

namespace itsync.Foundation
{
	/// <summary>
	/// 描述一个部件的相关细节。
	/// </summary>
	public class Component : Object
	{
		/// <summary>
		/// 描述本部件的各个细节参数。
		/// 系统支持多个参数信息的并存。
		/// </summary>
		public Collection<Item> Parameters { set; get; }

		public Component()
			: base()
		{
			this.Parameters = new Collection<Item>();
		}

		public Component(Guid uiGuid, string szName, string szDescription)
			: base(uiGuid, szName, szDescription)
		{
			this.Parameters = new Collection<Item>();
		}
	}
}
