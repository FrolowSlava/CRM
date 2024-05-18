using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Common.Enums;
using Entities;

namespace UI.Areas.Admin.Models
{
	public class RoleModel
	{
		[Required(ErrorMessage = "Укажите значение")]
		[Display(Name = "RolesId")]
		public int RolesId { get; set; }

		[Display(Name = "RoleName")]
		public string RoleName { get; set; }

		[Display(Name = "Salary")]
		public int? Salary { get; set; }

		public static RoleModel FromEntity(Role obj)
		{
			return obj == null ? null : new RoleModel
			{
				RolesId = obj.RolesId,
				RoleName = obj.RoleName,
				Salary = obj.Salary,
			};
		}

		public static Role ToEntity(RoleModel obj)
		{
			return obj == null ? null : new Role(obj.RolesId, obj.RoleName, obj.Salary);
		}

		public static List<RoleModel> FromEntitiesList(IEnumerable<Role> list)
		{
			return list?.Select(FromEntity).ToList();
		}

		public static List<Role> ToEntitiesList(IEnumerable<RoleModel> list)
		{
			return list?.Select(ToEntity).ToList();
		}
	}
}
