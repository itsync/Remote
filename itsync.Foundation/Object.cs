using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itsync.Foundation
{
	/// <summary>
	/// 系统中所有数据应用的基础类。
	/// 本类只用于继承，不能用于生成实际的实例。
	/// </summary>
    public class Object
    {
		/// <summary>
		/// 本对象在系统内部的编号。
		/// </summary>
		public Guid Guid { set; get; }

		/// <summary>
		/// 本对象的名称。
		/// 其长度不超过128个英文字符。
		/// </summary>
		public string Name { set; get; }

		/// <summary>
		/// 本对象的描述。
		/// 其长度不超过1024个英文字符。
		/// </summary>
		public string Description { set; get; }

		/// <summary>
		/// 本对象的建立日期和时间。
		/// </summary>
		public DateTime Created { set; get; }

		/// <summary>
		/// 本对象上次被修改的日期和时间。
		/// </summary>
		public DateTime Modified { set; get; }

		public Object()
		{
			this.Guid = new Guid();
			this.Name = "";
			this.Description = "";
			this.Created = DateTime.Now;
			this.Modified = DateTime.Now;
		}

		public Object(Guid uiGuid, string szName, string szDescription)
		{
			this.Guid = new Guid(uiGuid.ToString());
			this.Name = szName;
			this.Description = szDescription;
			this.Created = DateTime.Now;
			this.Modified = DateTime.Now;
		}
    }
}
