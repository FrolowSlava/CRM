using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Common.Enums;
using Entities;

namespace UI.Areas.Admin.Models
{
	public class DetailsOnOrderModel
	{
		[Required(ErrorMessage = "Укажите значение")]
		[Display(Name = "DetailId")]
		public int DetailId { get; set; }

		[Required(ErrorMessage = "Укажите значение")]
		[Display(Name = "OrderId")]
		public int OrderId { get; set; }

		[Display(Name = "Count")]
		public int? Count { get; set; }

		public static DetailsOnOrderModel FromEntity(DetailsOnOrder obj)
		{
			return obj == null ? null : new DetailsOnOrderModel
			{
				DetailId = obj.DetailId,
				OrderId = obj.OrderId,
				Count = obj.Count,
			};
		}

		public static DetailsOnOrder ToEntity(DetailsOnOrderModel obj)
		{
			return obj == null ? null : new DetailsOnOrder(obj.DetailId, obj.OrderId, obj.Count);
		}

		public static List<DetailsOnOrderModel> FromEntitiesList(IEnumerable<DetailsOnOrder> list)
		{
			return list?.Select(FromEntity).ToList();
		}

		public static List<DetailsOnOrder> ToEntitiesList(IEnumerable<DetailsOnOrderModel> list)
		{
			return list?.Select(ToEntity).ToList();
		}
	}
}
