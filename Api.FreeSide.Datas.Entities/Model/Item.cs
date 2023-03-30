using System;
using System.Collections.Generic;

namespace Api.FreeSide.Datas.Entities.Model;

public partial class Item
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? Name { get; set; }

    public float? Price { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }

    public int? Stock { get; set; }
}
