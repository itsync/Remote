using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itsync.Foundation.helper
{
	/// <summary>
	/// 提供对“对象(Object)”有关的操作。
	/// 这是一个辅助类，主要用于简化代码的编写，并且提高操作的可靠性。
	/// </summary>
	/// <typeparam name="T">需要操作的对象类型</typeparam>
	class Collection<T> : ObservableCollection<T>
	{
	}
}
