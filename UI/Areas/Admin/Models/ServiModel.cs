using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Common.Enums;
using Entities;

namespace UI.Areas.Admin.Models
{
	public class ServiModel
	{
		[Required(ErrorMessage = "Укажите значение")]
		[Display(Name = "ServisId")]
		public int ServisId { get; set; }

		[Display(Name = "Name")]
		public string Name { get; set; }

		[Display(Name = "Price")]
		public int? Price { get; set; }

		[Display(Name = "ExecutionTime")]
		public int? ExecutionTime { get; set; }

		public static ServiModel FromEntity(Servi obj)
		{
			return obj == null ? null : new ServiModel
			{
				ServisId = obj.ServisId,
				Name = obj.Name,
				Price = obj.Price,
				ExecutionTime = obj.ExecutionTime,
			};
		}

		public static Servi ToEntity(ServiModel obj)
		{
			return obj == null ? null : new Servi(obj.ServisId, obj.Name, obj.Price, obj.ExecutionTime);
		}

		public static List<ServiModel> FromEntitiesList(IEnumerable<Servi> list)
		{
			return list?.Select(FromEntity).ToList();
		}

		public static List<Servi> ToEntitiesList(IEnumerable<ServiModel> list)
		{
			return list?.Select(ToEntity).ToList();
		}
	}
}
