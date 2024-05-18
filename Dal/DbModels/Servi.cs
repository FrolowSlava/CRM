using System;
using System.Collections.Generic;

namespace Dal.DbModels;

public partial class Servi
{
    public int ServisId { get; set; }

    public string Name { get; set; }

    public int? Price { get; set; }

    public int? ExecutionTime { get; set; }

    public virtual ICollection<DescriptionServi> DescriptionServis { get; set; } = new List<DescriptionServi>();
}
