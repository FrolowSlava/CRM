using System;
using System.Collections.Generic;

namespace Dal.DbModels;

public partial class Client
{
    public int ClientId { get; set; }

    public string Name { get; set; }

    public string Phone { get; set; }

    public string Order { get; set; }

    public int? SpentSum { get; set; }

    public int? BonusLevel { get; set; }

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
