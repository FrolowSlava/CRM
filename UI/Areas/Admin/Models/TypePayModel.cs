using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Common.Enums;
using Entities;

namespace UI.Areas.Admin.Models
{
	public class TypePayModel
	{
		[Required(ErrorMessage = "Укажите значение")]
		[Display(Name = "TypePayId")]
		public int TypePayId { get; set; }

		[Display(Name = "ByCash")]
		public bool? ByCash { get; set; }

		[Display(Name = "ByCard")]
		public bool? ByCard { get; set; }

		public static TypePayModel FromEntity(TypePay obj)
		{
			return obj == null ? null : new TypePayModel
			{
				TypePayId = obj.TypePayId,
				ByCash = obj.ByCash,
				ByCard = obj.ByCard,
			};
		}

		public static TypePay ToEntity(TypePayModel obj)
		{
			return obj == null ? null : new TypePay(obj.TypePayId, obj.ByCash, obj.ByCard);
		}

		public static List<TypePayModel> FromEntitiesList(IEnumerable<TypePay> list)
		{
			return list?.Select(FromEntity).ToList();
		}

		public static List<TypePay> ToEntitiesList(IEnumerable<TypePayModel> list)
		{
			return list?.Select(ToEntity).ToList();
		}
	}
}
