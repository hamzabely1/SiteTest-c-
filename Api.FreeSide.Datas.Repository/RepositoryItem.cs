using Api.FreeSide.Datas.Context.Contact;
using Api.FreeSide.Datas.Entities.Model;
using Api.FreeSide.Datas.Repository.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.FreeSide.Datas.Repository
{
    public class RepositoryItem : GenericRepository<Item>, IRepositoryItem
    {
        public RepositoryItem(IFreeSideContext _ifreeSideContext) : base(_ifreeSideContext)
        {
        }
    }
}
