using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.FreeSide.Business.Model.Item
{
    public class ItemReadDTO : ItemBaseDTO
    {
        public int ItemId { get; set; }
        public DateTime ItemCreaTime { get; set; }
        public string? ItemName { get; set; }

        public string? ItemDescription { get; set; }

        public int ItemStock { get; set; }

        public float ItemPrice { get; set; }

        public string? ItemImage { get; set; }
    }
}
