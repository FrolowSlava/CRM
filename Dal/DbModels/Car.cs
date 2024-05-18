using System;
using System.Collections.Generic;

namespace Dal.DbModels;

public partial class Car
{
    public int CarId { get; set; }

    public int? ClientId { get; set; }

    public string Model { get; set; }

    public string Year { get; set; }

    public int? Mileage { get; set; }

    public virtual Client Client { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
