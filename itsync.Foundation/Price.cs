using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using itsync.Foundation.helper;

namespace itsync.Foundation
{
	/// <summary>
	/// 描述价格的相关信息。
	/// </summary>
	public class Price : Object
	{
		/// <summary>
		/// 描述所有可能的货币种类。
		/// </summary>
		public enum currency { None = 0, RMB, USD, YEN, EUR };
		public currency Currency { set; get; }

		/// <summary>
		/// 价格具体的金额值。
		/// </summary>
		public float Value { set; get; }

		/// <summary>
		/// 是否有截止日期，以及具体的时间。
		/// </summary>
		public Dateflag Deadline { set; get; }

		public Price()
			: base()
		{
			this.Currency = currency.None;
			this.Value = 0.0f;
			this.Deadline = new Dateflag();
		}

		public Price(currency enCurrency, float fValue)
			: base()
		{
			this.Currency = enCurrency;
			this.Value = fValue;
			this.Deadline = new Dateflag();
		}

		public Price(currency enCurrency, float fValue, Dateflag dataDeadline)
		{
			this.Currency = enCurrency;
			this.Value = fValue;
			this.Deadline = dataDeadline;
		}
	}
}
