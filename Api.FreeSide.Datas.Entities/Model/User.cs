using System;
using System.Collections.Generic;

namespace Api.FreeSide.Datas.Entities.Model;

public partial class User
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateTime? DateBirth { get; set; }

    public int? Address { get; set; }

    public string? Numero { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }
}
