using System;
using System.Collections.Generic;
using System.Linq;
using Common.Enums;

namespace Entities
{
	public class Detail
	{
		public int DetailId { get; set; }
		public string DetailName { get; set; }
		public int? Price { get; set; }
		public int? Count { get; set; }

		public Detail(int detailId, string detailName, int? price, int? count)
		{
			DetailId = detailId;
			DetailName = detailName;
			Price = price;
			Count = count;
		}
	}
}
