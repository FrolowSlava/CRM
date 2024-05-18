using System;
using System.Collections.Generic;

namespace Dal.DbModels;

public partial class Worker
{
    public int WorkerId { get; set; }

    public string WorkerName { get; set; }

    public int? RolesId { get; set; }

    public bool? IsBusy { get; set; }

    public virtual ICollection<DescriptionServi> DescriptionServis { get; set; } = new List<DescriptionServi>();

    public virtual Role Roles { get; set; }
}
