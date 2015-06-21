using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using itsync.Foundation.helper;

namespace itsync.Foundation
{
	/// <summary>
	/// 描述所有的功能，包括“基本功能(Operation)”和“功能选件(Option)”。
	/// </summary>
	public class Behavior : Object
	{
		/// <summary>
		/// 描述所有的基本功能。
		/// </summary>
		public Collection<Item> Operations { set; get; }

		/// <summary>
		/// 描述所有的选型功能。
		/// </summary>
		public Collection<Option> Options { set; get; }

		public Behavior()
			: base()
		{
			this.Operations = new Collection<Item>();
			this.Options = new Collection<Option>();
		}
	}
}
