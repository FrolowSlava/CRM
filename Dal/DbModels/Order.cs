using System;
using System.Collections.Generic;

namespace Dal.DbModels;

public partial class Order
{
    public int OrderId { get; set; }

    public DateTime? Date { get; set; }

    public int? ClientId { get; set; }

    public int? CarId { get; set; }

    public string WorkStatus { get; set; }

    public int? TypePayId { get; set; }

    public virtual Car Car { get; set; }

    public virtual Client Client { get; set; }

    public virtual ICollection<DescriptionServi> DescriptionServis { get; set; } = new List<DescriptionServi>();

    public virtual ICollection<DetailsOnOrder> DetailsOnOrders { get; set; } = new List<DetailsOnOrder>();

    public virtual TypePay TypePay { get; set; }
}
