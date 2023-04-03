using Api.FreeSide.Business.Model.Item;
using Api.FreeSide.Business.Model.User;
using Api.FreeSide.Business.Service;
using Api.FreeSide.Business.Service.Contact;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Free_Side_.Controllers
   
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller

    {
        private readonly IServiceUser _serviceUser;
        public UserController(IServiceUser serviceUser)
        {
            _serviceUser = serviceUser;
        }

        [HttpGet()]
        [ProducesResponseType(typeof(IEnumerable<UserReadDTO>), 200)]
        [ProducesResponseType(typeof(StatusCodeResult), 500)]
        [ProducesResponseType(typeof(StatusCodeResult), 400)]
        public async Task<ActionResult> Get()
        {
            var user = await _serviceUser.GetListUserAsync().ConfigureAwait(false);

            return Ok(user);
        }

        /// <summary>
        /// post
        /// </summary>
        /// <returns></returns>
        [HttpPost()]
        [ProducesResponseType(typeof(UserReadDTO), 200)]
        [ProducesResponseType(typeof(StatusCodeResult), 500)]
        [ProducesResponseType(typeof(StatusCodeResult), 400)]
        public async Task<ActionResult> Post(UserAddDTO userToRead)
        {
            var user = await _serviceUser.CreateUserAsync(userToRead).ConfigureAwait(false);

            return Ok(user);
        }

        /// <summary>
        /// ge un
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(UserReadDTO), 200)]
        [ProducesResponseType(typeof(StatusCodeResult), 500)]
        [ProducesResponseType(typeof(StatusCodeResult), 400)]
        public async Task<ActionResult> GetUn(int id)
        {
            var user = await _serviceUser.GetUnUserAsync(id).ConfigureAwait(false);

            return Ok(user);
        }


        /// <summary>
        /// delete
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(UserReadDTO), 200)]
        [ProducesResponseType(typeof(StatusCodeResult), 500)]
        [ProducesResponseType(typeof(StatusCodeResult), 400)]
        public async Task<ActionResult> Delete(int id)
        {
            var user = await _serviceUser.DeleteUserAsync(id).ConfigureAwait(false);

            return Ok(user);
        }





    }


}
