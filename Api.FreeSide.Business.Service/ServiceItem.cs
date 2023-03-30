using Api.FreeSide.Business.Service.Contact;
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
    }
}
