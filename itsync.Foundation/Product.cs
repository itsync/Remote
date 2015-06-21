using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using itsync.Foundation.helper;

namespace itsync.Foundation
{
	/// <summary>
	/// 描述一个具体的产品信息。
	/// </summary>
	public class Product : Object
	{
		/// <summary>
		/// 描述本产品的型号，其长度为“四位”阿拉伯数字。
		/// 例如：在综合信息发布系统的“机顶盒”中，有一个型号为“1800”。
		/// </summary>
		public string Model { set; get; }

		/// <summary>
		/// 描述本产品型号的后缀。
		/// </summary>
		public string Postfix { set; get; }

		/// <summary>
		/// 描述本产品中软件所能实现的性能。
		/// 这是产品“用途(Usage)”中所定义软件功能的一个“子集”，主要用于产品介绍或者产品报价。
		/// </summary>
		public Behavior Software { set; get; }

		/// <summary>
		/// 描述本产品中硬件所能实现的性能。
		/// 这是产品“用途(Usage)”中所定义硬件功能的一个“子集”，，主要用于产品介绍或者产品报价
		/// </summary>
		public Behavior Hardware { set; get; }

		public Product()
			: base()
		{
			this.Model = "";
			this.Postfix = "";
			this.Software = new Behavior();
			this.Hardware = new Behavior();
		}

		public Product(string szModel)
			: base()
		{
			this.Model = szModel;
			this.Postfix = "";
			this.Software = new Behavior();
			this.Hardware = new Behavior();
		}

		public Product(string szModel, string szPostfix)
			: base()
		{
			this.Model = szModel;
			this.Postfix = szPostfix;
			this.Software = new Behavior();
			this.Hardware = new Behavior();
		}
	}
}
