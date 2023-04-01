using Api.FreeSide.Business.Model.Item;
using Api.FreeSide.Business.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.FreeSide.Business.Service.Contact
{
    public interface IServiceItem
    {
        Task<List<ItemReadDTO>> GetListItemAsync();


    }
}
