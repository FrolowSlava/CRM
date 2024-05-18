using System;
using System.Collections.Generic;
using System.Linq;
using Common.Enums;

namespace Entities
{
	public class Client
	{
		public int ClientId { get; set; }
		public string Name { get; set; }
		public string Phone { get; set; }
		public string Order { get; set; }
		public int? SpentSum { get; set; }
		public int? BonusLevel { get; set; }

		public Client(int clientId, string name, string phone, string order, int? spentSum, int? bonusLevel)
		{
			ClientId = clientId;
			Name = name;
			Phone = phone;
			Order = order;
			SpentSum = spentSum;
			BonusLevel = bonusLevel;
		}
	}
}
