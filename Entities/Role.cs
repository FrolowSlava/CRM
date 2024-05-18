using System;
using System.Collections.Generic;
using System.Linq;
using Common.Enums;

namespace Entities
{
	public class Role
	{
		public int RolesId { get; set; }
		public string RoleName { get; set; }
		public int? Salary { get; set; }

		public Role(int rolesId, string roleName, int? salary)
		{
			RolesId = rolesId;
			RoleName = roleName;
			Salary = salary;
		}
	}
}
