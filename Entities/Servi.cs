using System;
using System.Collections.Generic;
using System.Linq;
using Common.Enums;

namespace Entities
{
	public class Servi
	{
		public int ServisId { get; set; }
		public string Name { get; set; }
		public int? Price { get; set; }
		public int? ExecutionTime { get; set; }

		public Servi(int servisId, string name, int? price, int? executionTime)
		{
			ServisId = servisId;
			Name = name;
			Price = price;
			ExecutionTime = executionTime;
		}
	}
}
