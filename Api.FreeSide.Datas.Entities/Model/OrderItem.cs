using System;
using System.Collections.Generic;

namespace Api.FreeSide.Datas.Entities.Model;

public partial class OrderItem
{
    public int Id { get; set; }

    public int? IdOrder { get; set; }

    public int? IdItem { get; set; }
}
