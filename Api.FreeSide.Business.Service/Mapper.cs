using Api.FreeSide.Business.Model.Item;
using Api.FreeSide.Business.Model.User;
using Api.FreeSide.Datas.Entities.Model;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.FreeSide.Business.Service
{
    public class Mapper
    {
        public static UserReadDTO TransformUserToDTO(User user)
        {
            UserReadDTO userRead = new UserReadDTO()
            {
                UserNumero = user.Numero,
                UserAddress = (int)user.Address,
                UserLastName = user.LastName,
                UserFirstName = user.FirstName,
                UserDateBirth = (DateTime)user.DateBirth,
                UserEmail = user.Email,
                UserPassword = user.Password

            };

            return userRead;

        }

        public static ItemReadDTO TransformItemToDTO(Item item)
        {
            ItemReadDTO itemRead = new ItemReadDTO()
            {
                ItemName = item.Name,
                ItemDescription = item.Description,
                ItemCreaTime = (DateTime)item.CreateTime,
                ItemImage = item.Image,
                ItemPrice = (float)item.Price,
                ItemStock = (int)item.Stock,
            };

            return itemRead;

        }
    }
}
