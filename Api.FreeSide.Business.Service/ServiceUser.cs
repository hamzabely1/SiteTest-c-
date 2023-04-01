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

        /// <summary>
        /// get user
        /// </summary>
        /// <returns></returns>
       public async Task<List<UserReadDTO>> GetListUserAsync()
        {
            var users = await _repositoryUser.GetAllAsync().ConfigureAwait(false);

            List<UserReadDTO> userDtos = new();

            foreach (var user in users)
            {
               userDtos.Add(Mapper.TransformUserToDTO(user));
            }

            return userDtos;
        }

        /// <summary>
        /// post user
        /// </summary>
        /// <param name="etudiantToRead"></param>
        /// <returns></returns>
        public async Task<UserReadDTO> CreateUserAsync(UserAddDTO userToRead)
        {
            User newUser = new User()
            {
                FirstName = userToRead.UserFirstName,
                LastName = userToRead.UserLastName,
                Address = userToRead.UserAddress,
                Email = userToRead.UserEmail,
                Numero= userToRead.UserNumero,
                DateBirth = userToRead.UserDateBirth,
                CreateTime = userToRead.UserCreeTime,
                Password= userToRead.UserPassword,

            };

            var user = await _repositoryUser.CreateElementAsync(newUser).ConfigureAwait(false);

            //utiliser le readDTO
            return Mapper.TransformUserToDTO(user);
        }


    }
}
