using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using itsync.Foundation.helper;

namespace itsync.Foundation
{
	/// <summary>
	/// 描述一个供应商的相关信息。
	/// </summary>
	public class Vendor : Object
	{
		/// <summary>
		/// 供应商的办公地址。
		/// 其长度不超过256个英文字符。
		/// </summary>
		public string Address { set; get; }

		/// <summary>
		/// 供应商办公地址的邮政编码。
		/// 其长度不超过16个英文字符。
		/// </summary>
		public string Postcode { set;get; }

		/// <summary>
		/// 供应商的网址信息。
		/// 系统支持多个网址同时并存。
		/// </summary>
		public Collection<Item> Webs { set; get; }

		/// <summary>
		/// 供应商的电话信息。
		/// 系统支持多个电话信息同时并存。
		/// </summary>
		public Collection<Item> Telephones { set;get; }

		/// <summary>
		/// 供应商的传真信息。
		/// 系统支持多个传真信息同时并存。
		/// </summary>
		public Collection<Item> Faxs { set; get; }

		/// <summary>
		/// 供应商的电子邮件信息。
		/// 系统支持多个电子邮件信息的并存。
		/// </summary>
		public Collection<Item> Emails { set; get; }

		/// <summary>
		/// 供应商的联系人信息。
		/// 系统支持多个联系人信息的并存。
		/// </summary>
		public Collection<Item> Contactors { set; get; }

		public Vendor()
			: base()
		{
			this.Address = "";
			this.Postcode = "";
			this.Webs = new Collection<Item>();
			this.Telephones = new Collection<Item>();
			this.Faxs = new Collection<Item>();
			this.Emails = new Collection<Item>();
			this.Contactors = new Collection<Item>();
		}

		public Vendor(Guid uiGuid, string szName, string szDescription,
			string szAddress, string szPostcode)
			: base(uiGuid, szName, szDescription)
		{
			this.Address = szAddress;
			this.Postcode = szPostcode;
			this.Webs = new Collection<Item>();
			this.Telephones = new Collection<Item>();
			this.Faxs = new Collection<Item>();
			this.Emails = new Collection<Item>();
			this.Contactors = new Collection<Item>();			
		}
	}
}
