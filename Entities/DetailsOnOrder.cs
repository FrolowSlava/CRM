using System;
using System.Collections.Generic;
using System.Linq;
using Common.Enums;

namespace Entities
{
	public class DetailsOnOrder
	{
		public int DetailId { get; set; }
		public int OrderId { get; set; }
		public int? Count { get; set; }

		public DetailsOnOrder(int detailId, int orderId, int? count)
		{
			DetailId = detailId;
			OrderId = orderId;
			Count = count;
		}
	}
}
