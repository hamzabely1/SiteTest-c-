using Api.FreeSide.Datas.Entities.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Api.FreeSide.Datas.Context.Contact
{
    public class IFreeSideContext
    {
        DbSet<Address> Addresses { get; set; }

        DbSet<Item> Items { get; set; }

        DbSet<Order> Orders { get; set; }

        DbSet<OrderItem> OrderItems { get; set; }

        DbSet<User> Users { get; set; }
    }
}
