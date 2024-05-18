using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Common.Enums;
using Entities;

namespace UI.Areas.Admin.Models
{
	public class DetailModel
	{
		[Required(ErrorMessage = "Укажите значение")]
		[Display(Name = "DetailId")]
		public int DetailId { get; set; }

		[Display(Name = "DetailName")]
		public string DetailName { get; set; }

		[Display(Name = "Price")]
		public int? Price { get; set; }

		[Display(Name = "Count")]
		public int? Count { get; set; }

		public static DetailModel FromEntity(Detail obj)
		{
			return obj == null ? null : new DetailModel
			{
				DetailId = obj.DetailId,
				DetailName = obj.DetailName,
				Price = obj.Price,
				Count = obj.Count,
			};
		}

		public static Detail ToEntity(DetailModel obj)
		{
			return obj == null ? null : new Detail(obj.DetailId, obj.DetailName, obj.Price, obj.Count);
		}

		public static List<DetailModel> FromEntitiesList(IEnumerable<Detail> list)
		{
			return list?.Select(FromEntity).ToList();
		}

		public static List<Detail> ToEntitiesList(IEnumerable<DetailModel> list)
		{
			return list?.Select(ToEntity).ToList();
		}
	}
}
