using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.FreeSide.Datas.Context.Contact;
using Api.FreeSide.Datas.Entities.Model;
using Api.FreeSide.Datas.Repository.Contact;

namespace Api.FreeSide.Datas.Repository
{
    public class RepositoryUser : GenericRepository<User>, IRepositoryUser
    {
        public RepositoryUser(IFreeSideContext _ifreeSideContext) : base(_ifreeSideContext)
        {
        }
    }
}
