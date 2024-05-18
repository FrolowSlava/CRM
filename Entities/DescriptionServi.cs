using System;
using System.Collections.Generic;
using System.Linq;
using Common.Enums;

namespace Entities
{
	public class DescriptionServi
	{
		public int DescriptionServisId { get; set; }
		public int? ServisId { get; set; }
		public int? OrderId { get; set; }
		public int? WorkerId { get; set; }

		public DescriptionServi(int descriptionServisId, int? servisId, int? orderId, int? workerId)
		{
			DescriptionServisId = descriptionServisId;
			ServisId = servisId;
			OrderId = orderId;
			WorkerId = workerId;
		}
	}
}
