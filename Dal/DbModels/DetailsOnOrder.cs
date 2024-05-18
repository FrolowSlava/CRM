using System;
using System.Collections.Generic;

namespace Dal.DbModels;

public partial class DetailsOnOrder
{
    public int DetailId { get; set; }

    public int OrderId { get; set; }

    public int? Count { get; set; }

    public virtual Detail Detail { get; set; }

    public virtual Order Order { get; set; }
}
