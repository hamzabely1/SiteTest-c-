using Api.FreeSide.Business.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.FreeSide.Business.Service.Contact
{
    public interface IServiceUser
    {
       Task<List<UserReadDTO>> GetListUserAsync();

       Task<UserReadDTO> CreateUserAsync(UserAddDTO UserToAdd);

       Task<UserReadDTO> GetUnUserAsync(int id);

       
       Task<UserReadDTO> DeleteUserAsync(int id);




    }
}
