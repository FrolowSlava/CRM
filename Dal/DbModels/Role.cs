using System;
using System.Collections.Generic;

namespace Dal.DbModels;

public partial class Role
{
    public int RolesId { get; set; }

    public string RoleName { get; set; }

    public int? Salary { get; set; }

    public virtual ICollection<Worker> Workers { get; set; } = new List<Worker>();
}
