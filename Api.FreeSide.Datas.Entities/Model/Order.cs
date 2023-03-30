using System;
using System.Collections.Generic;

namespace Api.FreeSide.Datas.Entities.Model;

public partial class Order
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public int? IdClient { get; set; }

    public int? TotalPrice { get; set; }
}
