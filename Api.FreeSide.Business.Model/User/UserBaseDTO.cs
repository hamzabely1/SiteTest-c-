using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.FreeSide.Business.Model.User
{
    public class UserBaseDTO
    {


        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserEmail { get; set; }
        public string UserNumero { get; set; }
        public DateTime UserDateBirth { get; set; }
        public int UserAddress { get; set; }

        public DateTime UserCreeTime { get; set; }

        public string UserPassword { get; set; }

    }
}
