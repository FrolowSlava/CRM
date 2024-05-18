using System;
using System.Collections.Generic;

namespace Dal.DbModels;

public partial class DescriptionServi
{
    public int DescriptionServisId { get; set; }

    public int? ServisId { get; set; }

    public int? OrderId { get; set; }

    public int? WorkerId { get; set; }

    public virtual Order Order { get; set; }

    public virtual Servi Servis { get; set; }

    public virtual Worker Worker { get; set; }
}
