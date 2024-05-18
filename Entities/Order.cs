using System;
using System.Collections.Generic;
using System.Linq;
using Common.Enums;

namespace Entities
{
	public class Order
	{
		public int OrderId { get; set; }
		public DateTime? Date { get; set; }
		public int? ClientId { get; set; }
		public int? CarId { get; set; }
		public string WorkStatus { get; set; }
		public int? TypePayId { get; set; }

		public Order(int orderId, DateTime? date, int? clientId, int? carId, string workStatus, int? typePayId)
		{
			OrderId = orderId;
			Date = date;
			ClientId = clientId;
			CarId = carId;
			WorkStatus = workStatus;
			TypePayId = typePayId;
		}
	}
}
