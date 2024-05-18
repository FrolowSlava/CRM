using System;
using System.Collections.Generic;

namespace Dal.DbModels;

public partial class TypePay
{
    public int TypePayId { get; set; }

    public bool? ByCash { get; set; }

    public bool? ByCard { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
