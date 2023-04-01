using Api.FreeSide.Business.Model.Item;
using Api.FreeSide.Business.Service.Contact;
using Api.FreeSide.Datas.Repository;
using Api.FreeSide.Datas.Repository.Contact;
using System;
using System.Collections.Generic;
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
    }
}
