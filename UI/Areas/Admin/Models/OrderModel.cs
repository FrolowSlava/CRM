using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Common.Enums;
using Entities;

namespace UI.Areas.Admin.Models
{
	public class OrderModel
	{
		[Required(ErrorMessage = "Укажите значение")]
		[Display(Name = "OrderId")]
		public int OrderId { get; set; }

		[Display(Name = "Date")]
		public DateTime? Date { get; set; }

		[Display(Name = "ClientId")]
		public int? ClientId { get; set; }

		[Display(Name = "CarId")]
		public int? CarId { get; set; }

		[Display(Name = "WorkStatus")]
		public string WorkStatus { get; set; }

		[Display(Name = "TypePayId")]
		public int? TypePayId { get; set; }

		public static OrderModel FromEntity(Order obj)
		{
			return obj == null ? null : new OrderModel
			{
				OrderId = obj.OrderId,
				Date = obj.Date,
				ClientId = obj.ClientId,
				CarId = obj.CarId,
				WorkStatus = obj.WorkStatus,
				TypePayId = obj.TypePayId,
			};
		}

		public static Order ToEntity(OrderModel obj)
		{
			return obj == null ? null : new Order(obj.OrderId, obj.Date, obj.ClientId, obj.CarId, obj.WorkStatus,
				obj.TypePayId);
		}

		public static List<OrderModel> FromEntitiesList(IEnumerable<Order> list)
		{
			return list?.Select(FromEntity).ToList();
		}

		public static List<Order> ToEntitiesList(IEnumerable<OrderModel> list)
		{
			return list?.Select(ToEntity).ToList();
		}
	}
}
