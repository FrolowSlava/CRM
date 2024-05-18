using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Common.Enums;
using Entities;

namespace UI.Areas.Admin.Models
{
	public class DescriptionServiModel
	{
		[Required(ErrorMessage = "Укажите значение")]
		[Display(Name = "DescriptionServisId")]
		public int DescriptionServisId { get; set; }

		[Display(Name = "ServisId")]
		public int? ServisId { get; set; }

		[Display(Name = "OrderId")]
		public int? OrderId { get; set; }

		[Display(Name = "WorkerId")]
		public int? WorkerId { get; set; }

		public static DescriptionServiModel FromEntity(DescriptionServi obj)
		{
			return obj == null ? null : new DescriptionServiModel
			{
				DescriptionServisId = obj.DescriptionServisId,
				ServisId = obj.ServisId,
				OrderId = obj.OrderId,
				WorkerId = obj.WorkerId,
			};
		}

		public static DescriptionServi ToEntity(DescriptionServiModel obj)
		{
			return obj == null ? null : new DescriptionServi(obj.DescriptionServisId, obj.ServisId, obj.OrderId,
				obj.WorkerId);
		}

		public static List<DescriptionServiModel> FromEntitiesList(IEnumerable<DescriptionServi> list)
		{
			return list?.Select(FromEntity).ToList();
		}

		public static List<DescriptionServi> ToEntitiesList(IEnumerable<DescriptionServiModel> list)
		{
			return list?.Select(ToEntity).ToList();
		}
	}
}
