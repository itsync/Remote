using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using itsync.Foundation.helper;

namespace itsync.Foundation
{
	/// <summary>
	/// 描述一个产品系统的相关细节。
	/// </summary>
	public class System : Object
	{
		/// <summary>
		/// 描述本系统的代号，其长度为八个英文字符。
		/// 系统的代号的格式为“MagicXXX”，最后的三位字符是某个系统的缩写。
		/// 例如：综合信息发布系统的代号为“MagicInf”。
		/// </summary>
		public string Symbol { set; get; }

		/// <summary>
		/// 描述本系统中不同用途的产品。
		/// 例如：综合信息发布系统中的服务器、机顶盒等。
		/// </summary>
		public Collection<Usage> Usages;

		public System()
			: base()
		{
			this.Symbol = "";
			this.Usages = new Collection<Usage>();
		}

		public System(Guid uiGuid, string szName, string szDescription, string szSymbol)
			: base(uiGuid, szName, szDescription)
		{
			this.Symbol = szSymbol;
			this.Usages = new Collection<Usage>();
		}
	}
}
