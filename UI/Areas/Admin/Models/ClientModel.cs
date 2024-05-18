using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Common.Enums;
using Entities;

namespace UI.Areas.Admin.Models
{
	public class ClientModel
	{
		[Required(ErrorMessage = "Укажите значение")]
		[Display(Name = "ClientId")]
		public int ClientId { get; set; }

		[Display(Name = "Name")]
		public string Name { get; set; }

		[Display(Name = "Phone")]
		public string Phone { get; set; }

		[Display(Name = "Order")]
		public string Order { get; set; }

		[Display(Name = "SpentSum")]
		public int? SpentSum { get; set; }

		[Display(Name = "BonusLevel")]
		public int? BonusLevel { get; set; }

		public static ClientModel FromEntity(Client obj)
		{
			return obj == null ? null : new ClientModel
			{
				ClientId = obj.ClientId,
				Name = obj.Name,
				Phone = obj.Phone,
				Order = obj.Order,
				SpentSum = obj.SpentSum,
				BonusLevel = obj.BonusLevel,
			};
		}

		public static Client ToEntity(ClientModel obj)
		{
			return obj == null ? null : new Client(obj.ClientId, obj.Name, obj.Phone, obj.Order, obj.SpentSum,
				obj.BonusLevel);
		}

		public static List<ClientModel> FromEntitiesList(IEnumerable<Client> list)
		{
			return list?.Select(FromEntity).ToList();
		}

		public static List<Client> ToEntitiesList(IEnumerable<ClientModel> list)
		{
			return list?.Select(ToEntity).ToList();
		}
	}
}
