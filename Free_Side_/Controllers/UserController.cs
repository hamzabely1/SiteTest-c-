using Api.FreeSide.Business.Model.Item;
using Api.FreeSide.Business.Model.User;
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
        /*
         * Get: api/Etudiants
         * get all students
        */
        [HttpGet()]
        [ProducesResponseType(typeof(IEnumerable<UserReadDTO>), 200)]
        [ProducesResponseType(typeof(StatusCodeResult), 500)]
        [ProducesResponseType(typeof(StatusCodeResult), 400)]
        public async Task<ActionResult> UserListAsync()
        {
            var user = await _serviceUser.GetListUserAsync().ConfigureAwait(false);

            return Ok(user);
        }
    }


}
