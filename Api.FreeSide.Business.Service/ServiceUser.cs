using Api.FreeSide.Business.Model.User;
using Api.FreeSide.Business.Service.Contact;
using Api.FreeSide.Datas.Entities.Model;
using Api.FreeSide.Datas.Repository.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Api.FreeSide.Business.Service
{
    public class ServiceUser : IServiceUser
    {
        private readonly IRepositoryUser _repositoryUser;

        public ServiceUser(IRepositoryUser repositoryUser)
        {
            _repositoryUser = repositoryUser;
        }

        public async Task<UserReadDTO> CreateUserAsync(UserAddDTO userToRead)
        {
            User newUser = new User()
            {
               LastName = userToRead.UserLastName,
               FirstName = userToRead.UserFirstName,
               Email = userToRead.UserEmail,
               Address = userToRead.UserAddress,
               Password = userToRead.UserPassword,
               CreateTime= DateTime.Now,
               Numero= userToRead.UserNumero,
               DateBirth= DateTime.Now,
            };

            var user = await _repositoryUser.CreateElementAsync(newUser).ConfigureAwait(false);

            //utiliser le readDTO
            return Mapper.TransformUserToDTO(user);
        }



    }
}
