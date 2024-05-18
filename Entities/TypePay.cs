using System;
using System.Collections.Generic;
using System.Linq;
using Common.Enums;

namespace Entities
{
	public class TypePay
	{
		public int TypePayId { get; set; }
		public bool? ByCash { get; set; }
		public bool? ByCard { get; set; }

		public TypePay(int typePayId, bool? byCash, bool? byCard)
		{
			TypePayId = typePayId;
			ByCash = byCash;
			ByCard = byCard;
		}
	}
}
