using System;
using System.Collections.Generic;
using System.Linq;
using Common.Enums;

namespace Entities
{
	public class Car
	{
		public int CarId { get; set; }
		public int? ClientId { get; set; }
		public string Model { get; set; }
		public string Year { get; set; }
		public int? Mileage { get; set; }

		public Car(int carId, int? clientId, string model, string year, int? mileage)
		{
			CarId = carId;
			ClientId = clientId;
			Model = model;
			Year = year;
			Mileage = mileage;
		}
	}
}
