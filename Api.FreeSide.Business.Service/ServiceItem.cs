using Api.FreeSide.Business.Model.Item;
using Api.FreeSide.Business.Model.User;
using Api.FreeSide.Business.Service.Contact;
using Api.FreeSide.Datas.Entities.Model;
using Api.FreeSide.Datas.Repository;
using Api.FreeSide.Datas.Repository.Contact;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.FreeSide.Business.Service
{
    public class ServiceItem : IServiceItem

    {
        private readonly IRepositoryItem _repositoryItem;

        public ServiceItem(IRepositoryItem repositoryItem)
        {
            _repositoryItem = repositoryItem;
        }

        /// <summary>
        /// get list item
        /// </summary>
        /// <returns></returns>
        public async Task<List<ItemReadDTO>> GetListItemAsync()
        {
            var items = await _repositoryItem.GetAllAsync().ConfigureAwait(false);

            List<ItemReadDTO> itemDtos = new();

            foreach (var item in items)
            {
                itemDtos.Add(Mapper.TransformItemToDTO(item));
            }

            return itemDtos;
        }

        /// <summary>
        /// cree item
        /// </summary>
        /// <param name="itemToRead"></param>
        /// <returns></returns>
        public async Task<ItemReadDTO> CreateItemAsync(ItemAddDTO itemToRead)
        {
            Item newItem = new Item()
            {
                Name = itemToRead.ItemName,
                Price = itemToRead.ItemPrice,
                Stock= itemToRead.ItemStock,
                CreateTime = itemToRead.ItemCreaTime,
                Description= itemToRead.ItemDescription,
                Image = itemToRead.ItemImage
            };

            var item = await _repositoryItem.CreateElementAsync(newItem).ConfigureAwait(false);

            //utiliser le readDTO
            return Mapper.TransformItemToDTO(item);
        }
        /// <summary>
        /// get Un
        /// </summary>
        /// <returns></returns>
        public async Task<ItemReadDTO> GetUnItemAsync(int id)
        {

            var item = await _repositoryItem.GetByKeyAsync(id).ConfigureAwait(false);

            //utiliser le readDTO
            return Mapper.TransformItemToDTO(item);
        }


        /// <summary>
        /// delete 
        /// </summary>
        /// <returns></returns>
        public async Task<ItemReadDTO> DeleteItemAsync(int id)
        {

           Item itemId = await _repositoryItem.GetByKeyAsync(id).ConfigureAwait(false);


            var item = await _repositoryItem.DeleteElementAsync(itemId).ConfigureAwait(false);

            //utiliser le readDTO
            return  Mapper.TransformItemToDTO(item);
        }

        /// <summary>
        /// delete 
        /// </summary>
        /// <returns></returns>
        public async Task<ItemReadDTO> UpdateItemAsync(int id)
        {

            Item itemId = await _repositoryItem.GetByKeyAsync(id).ConfigureAwait(false);
            var item = await _repositoryItem.UpdateElementAsync(itemId).ConfigureAwait(false);

            //utiliser le readDTO
            return Mapper.TransformItemToDTO(item);
        }






    }
}
