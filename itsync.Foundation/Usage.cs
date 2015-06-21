using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using itsync.Foundation.helper;

namespace itsync.Foundation
{
	/// <summary>
	/// 描述一类特定用途的产品。
	/// 例如：综合信息发布系统中的“机顶盒”。
	/// </summary>
	public class Usage : Object
	{
		/// <summary>
		/// 描述这个用途产品在应用“流程(Flow)”上的分类。。
		/// 依据其不同的应用方式，所有的产品被分成了六种用途。
		/// 它们是“采集(Gather)”、“传输(Transfer)”、“处理(Process)”、“呈现(Present)”、“存储(Store)”以及“管理(Manage)”。
		/// </summary>
		public enum flow { None = 0, Gather, 
			Transfer, Process, Present, Store, Manage };
		public flow Flow { set; get; }

		/// <summary>
		/// 描述这类产品型号的前缀，其长度为三个英文字符。
		/// 例如：综合信息发布系统中“机顶盒”型号的前缀为“PST”。
		/// </summary>
		public string Prefix { set; get; }

		/// <summary>
		/// 描述这一类用途的产品中软件所能实现的所有功能。
		/// 在每种用途中某一个具体“产品(Product)”所能实现的软件功能，是这所有功能的一个“子集”。
		/// </summary>
		public Behavior Software { set; get; }

		/// <summary>
		/// 描述这一类用途的产品中硬件所能实现的所有功能
		/// 在每种用途中每一个具体“产品(Product)”所能实现的硬件功能，是这所有功能的一个“子集”。
		/// </summary>
		public Behavior Hardware { set; get; }

		/// <summary>
		/// 描述这类产品中所有产品的细节信息。
		/// 例如：综合信息发布系统中，“机顶盒”这类产品的各个型号。
		/// </summary>
		public Collection<Product> Products { set; get; }

		public Usage()
			: base()
		{
			this.Flow = flow.None;
			this.Prefix = "";
			this.Software = new Behavior();
			this.Hardware = new Behavior();
			this.Products = new Collection<Product>();
		}

		public Usage(flow enFlow, string szPrefix)
			: base()
		{
			this.Flow = enFlow;
			this.Prefix = szPrefix;
			this.Software = new Behavior();
			this.Hardware = new Behavior();
			this.Products = new Collection<Product>();
		}
	}
}
