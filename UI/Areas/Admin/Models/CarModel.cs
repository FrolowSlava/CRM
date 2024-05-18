using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Common.Enums;
using Entities;

namespace UI.Areas.Admin.Models
{
	public class CarModel
	{
		[Required(ErrorMessage = "Укажите значение")]
		[Display(Name = "CarId")]
		public int CarId { get; set; }

		[Display(Name = "ClientId")]
		public int? ClientId { get; set; }

		[Display(Name = "Model")]
		public string Model { get; set; }

		[Display(Name = "Year")]
		public string Year { get; set; }

		[Display(Name = "Mileage")]
		public int? Mileage { get; set; }

		public static CarModel FromEntity(Car obj)
		{
			return obj == null ? null : new CarModel
			{
				CarId = obj.CarId,
				ClientId = obj.ClientId,
				Model = obj.Model,
				Year = obj.Year,
				Mileage = obj.Mileage,
			};
		}

		public static Car ToEntity(CarModel obj)
		{
			return obj == null ? null : new Car(obj.CarId, obj.ClientId, obj.Model, obj.Year, obj.Mileage);
		}

		public static List<CarModel> FromEntitiesList(IEnumerable<Car> list)
		{
			return list?.Select(FromEntity).ToList();
		}

		public static List<Car> ToEntitiesList(IEnumerable<CarModel> list)
		{
			return list?.Select(ToEntity).ToList();
		}
	}
}
