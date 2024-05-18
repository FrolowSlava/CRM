using System;
using System.Collections.Generic;

namespace Dal.DbModels;

public partial class Detail
{
    public int DetailId { get; set; }

    public string DetailName { get; set; }

    public int? Price { get; set; }

    public int? Count { get; set; }

    public virtual ICollection<DetailsOnOrder> DetailsOnOrders { get; set; } = new List<DetailsOnOrder>();
}
