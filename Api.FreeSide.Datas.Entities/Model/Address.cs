using System;
using System.Collections.Generic;

namespace Api.FreeSide.Datas.Entities.Model;

public partial class Address
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? Street { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public int? PostalCode { get; set; }
}
